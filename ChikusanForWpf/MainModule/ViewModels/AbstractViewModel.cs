﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using Prism.Regions;
using JaGunma.MainModule.Behavior;

namespace JaGunma.MainModule.ViewModels
{
    /// <summary>
    /// ViewModelの抽象クラスです
    /// </summary>
        public abstract class AbstractViewModel :BindableBase, INotifyDataErrorInfo, INavigationAware,IRegionManagerAware
    {

        #region メンバ変数

        private ErrorsContainer<string> _errors;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        #endregion

        #region コンストラクタ

        public AbstractViewModel()
        {
            _errors = new ErrorsContainer<string>(OnErrorsChanged);
        }

        #endregion

        #region 実装

        public IEnumerable GetErrors(string propertyName)
        {
            return _errors.GetErrors(propertyName);
        }

        public bool HasErrors
        {
            get { return _errors.HasErrors; }
        }

        private IRegionManager _regionManager;
        public IRegionManager RegionManager
        {
            get { return this._regionManager; }
            set { this.SetProperty(ref this._regionManager, value); }
        }

        public abstract void OnNavigatedTo(NavigationContext navigationContext);
        public abstract bool IsNavigationTarget(NavigationContext navigationContext);
        public abstract void OnNavigatedFrom(NavigationContext navigationContext);

        #endregion

        #region メソッド

        private void OnErrorsChanged([CallerMemberName] string propertyName = null)
        {
            this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }


        protected void ValidateProperty(object value, [CallerMemberName] string propertyName = null)
        {
            var context = new ValidationContext(this)
            {
                MemberName = propertyName
            };
            var validationErrors = new List<ValidationResult>();
            if (!Validator.TryValidateProperty(value, context, validationErrors))
            {
                var errors = validationErrors.Select(error => error.ErrorMessage);
                this._errors.SetErrors(propertyName, errors);
            }
            else
            {
                this._errors.ClearErrors(propertyName);
            }
        }
        /// <summary>
        /// 検証
        /// </summary>
        /// <remarks>
        /// ValidateAllObjectsは、ICommandのCanExecuteで呼ぶものです。これを呼ばないと、画面表示時の初回判定を行ってくれません。
        /// </remarks>
        /// <returns></returns>
        internal bool ValidateAllObjects()
        {
            if (!this.HasErrors)
            {
                var context = new ValidationContext(this);
                var validationErrors = new List<ValidationResult>();
                if (Validator.TryValidateObject(this, context, validationErrors))
                {
                    return true;
                }

                var errors = validationErrors.Where(_ => _.MemberNames.Any()).GroupBy(_ => _.MemberNames.First());
                foreach (var error in errors)
                {
                    _errors.SetErrors(error.Key, error.Select(_ => _.ErrorMessage));
                }
            }
            return false;
        }

        #endregion

    }

}
