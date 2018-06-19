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
using JaGunma.MainModule.Models;
using JaGunma.MainModule.DataModels;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Reactive.Linq;

namespace JaGunma.MainModule.ViewModels
{
        public class AN82070ViewModel : AbstractViewModel
    {

        #region メンバ変数
        private AN82070Model _model { get; set; } = new AN82070Model();
        /// <summary>
        /// 品名コード開始
        /// </summary>
        /// <remark>
        /// ReactivePropertyを使用しないバインド
        /// ただしmodelからの通知をどう拾うか・・・
        /// この以外のメンバは全てReactivePropertyを使用
        /// </remark>
        private string _himmeiCodeStart;
        public string HimmeiCodeStart
        {
            get { return _himmeiCodeStart; }
            set
            {
                this._model.HimmeiCodeStart = value;
               this.SetProperty(ref this._himmeiCodeStart, this._model.HimmeiCodeStart);
            //this.ValidateProperty(value);
            }
        }

        /// <summary>
        /// フォーカス遷移プロパティ
        /// </summary>
        /// <remarks>
        /// VMからフォーカス遷移したい場合のみ使用
        /// </remarks>
        private bool _isHimmeiCodeStartFocused;
           public bool IsHimmeiCodeStartFocused
        {
            get { return _isHimmeiCodeStartFocused; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeStartFocused, value);
            }
        }
        public ReactiveProperty<string> HimmeiCodeEnd { get; private set; }
        public ReactiveProperty<string> Himmei { get; private set; }
        public ReactiveProperty<string> DantaiCodeStart { get; private set; }
        public ReactiveProperty<string> DantaiCodeEnd { get; private set; }
        public ReactiveProperty<string> DantaiName { get; private set; }
        public ReactiveProperty<string> KoushinshaCode { get; private set; }
        public ReactiveProperty<string> KoushinshaName { get; private set; }
        public ReactiveProperty<string> KoushinDateStart { get; private set; }
        public ReactiveProperty<string> KoushinDateEnd { get; private set; }
        public ReactiveProperty<bool> IsStop { get; private set; }
        public ReactiveProperty<string> ErrorMessage { get; private set; }
        public ReactiveProperty<bool> IsError { get; private set; }
        public ReactiveProperty<List<DantaiDataModel>> DantaiList { get; private set; }

        private DelegateCommand _searchCommand;
        public DelegateCommand SearchCommand
        {
            get
            {
                return this._searchCommand = this._searchCommand ?? new DelegateCommand(SearchDantaiIchiran);
            }
        }
        private DelegateCommand _clearCommand;
        public DelegateCommand ClearCommand
        {
            get
            {
                return this._clearCommand = this._clearCommand ?? new DelegateCommand(ClearDisplay);
            }
        }
        private DelegateCommand _moveEntryPageCommand;
        public DelegateCommand MoveEntryPageCommand
        {
            get
            {
                return this._moveEntryPageCommand = this._moveEntryPageCommand ?? new DelegateCommand(MoveEntryPage);
            }
        }

        public InteractionRequest<Notification> NotificationRequest { get; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> ConfirmationRequest { get; } = new InteractionRequest<Confirmation>();

        #endregion

        #region コンストラクタ
        public AN82070ViewModel(RegionManager regionManager) : base() {
            this.RegionManager = regionManager;
            ModelObjectMapping();
        }
        #endregion

        #region メソッド
        /// <summary>
        /// 団体一覧検索
        /// </summary>
        private void SearchDantaiIchiran()
        {
            if (!this._model.ExistSearchConditions()) return;
            this._model.ClearErrorMessage();
            this._model.SearchDantaiIchiran();
        }

        /// <summary>
        /// ModelとViewModelを紐づけ
        /// </summary>
        private void ModelObjectMapping()
        {
            this.HimmeiCodeEnd = this._model.ToReactivePropertyAsSynchronized(x => x.HimmeiCodeEnd);
            this.DantaiCodeStart = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiCodeStart);
            this.DantaiCodeEnd = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiCodeEnd);
            this.DantaiName = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiName);
            this.KoushinshaCode = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaCode);
            this.KoushinshaName = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaName);
            this.KoushinDateStart = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinDateStart);
            this.KoushinDateEnd = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinDateEnd);
            this.IsStop = this._model.ToReactivePropertyAsSynchronized(x => x.IsStop);
            this.ErrorMessage = this._model.ObserveProperty(x => x.ErrorMessage).ToReactiveProperty();
            this.IsError = this._model.ObserveProperty(x => x.ErrorMessage).Select(x => x == "" ? false : true).ToReactiveProperty();

            this.DantaiList = this._model.ObserveProperty(x => x.DantaiList).ToReactiveProperty();
        }

        /// <summary>
        /// 画面をクリア
        /// </summary>
        private void ClearDisplay()
        {
            this._model.InitializeModelItem();
            // Todo:これだけ例としてRP使用していないため、Model=>ViewModelに通知できない。RP必須？
            this.HimmeiCodeStart = string.Empty;

            this.IsHimmeiCodeStartFocused = true;
        }

        /// <summary>
        /// 登録画面遷移
        /// </summary>
        private void MoveEntryPage()
        {
            this.NotificationRequest.Raise(new Notification { Title = "警告", Content = "まだできてません。"});
            //this.RegionManager.RequestNavigate("MainRegion", nameof(Views.CalcResultView));
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
