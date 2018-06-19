using Prism.Commands;
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
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using JaGunma.Chikusan.Models;
using JaGunma.Chikusan.DataModels;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Reactive.Linq;

namespace JaGunma.Chikusan.ViewModels
{
        public class TestViewModel : AbstractViewModel
    {

        #region メンバ変数
          IRegionManager RegionManager;
        #endregion

        #region コンストラクタ
        public TestViewModel(RegionManager regionManager) : base() {
            this.RegionManager = regionManager;
        }
        #endregion

        #region メソッド
        /// <summary>
        /// 画面遷移
        /// </summary>
        private void ClosePage()
        {

        }

        #endregion

        #region 実装
        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //return this.Id == navigationContext.Parameters["id"] as string;
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
            //throw new NotImplementedException();
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        #endregion

    }

}
