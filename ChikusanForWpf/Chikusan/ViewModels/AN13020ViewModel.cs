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
using System.Windows.Navigation;
using JaGunma.Chikusan.Commons;
using JaGunma.Chikusan.Message;
using System.Collections.ObjectModel;
using JaGunma.Chikusan.RetentionData;
using System.Threading;

namespace JaGunma.Chikusan.ViewModels
{
        public class AN13020ViewModel : AbstractViewModel
    {

        #region メンバ変数
        //private AN22020Model _model { get; set; } = new AN22020Model();
        private ShikiriModel _model { get; set; } = new ShikiriModel();

        public ReactiveProperty<ShikiriDto> SelectedShikiri { get; private set; }
        public ReactiveProperty<ObservableCollection<ShikiriDto>> ShikiriList { get; private set; }
        //public ReactiveProperty<List<DantaiDto>> DantaiList { get; private set; }
        private CheckResult _checkResult;
        public CheckResult CheckResult
        {
            get { return this._checkResult; }
            set
            {
                this.SetProperty(ref this._checkResult, value);
            }
        }
        private bool _isAllSelected;
        public bool IsAllSelected
        {
            get { return this._isAllSelected; }
            set
            {
                this.SetProperty(ref this._isAllSelected, value);
            }
        }
        private bool _isLoading = false;
        public bool IsLoading
        {
            get { return this._isLoading; }
            set
            {
                this.SetProperty(ref this._isLoading, value);
            }
        }

        /// <summary>
        /// コンボボックステスト用
        /// </summary>
        private List<HimmeiDto> _himmei = new List<HimmeiDto>() { new HimmeiDto() { HimmeiCode = "1000" ,Himmei="肉豚"}, new HimmeiDto() { HimmeiCode = "3000", Himmei = "牛" } };
        public List<HimmeiDto>  Himmei
        {
            get { return this._himmei; }
            set
            {
                this.SetProperty(ref this._himmei, value);
            }
        }
        //public ReactiveProperty<bool> IsAllSelected { get; private set; }

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
                return this._moveEntryPageCommand = this._moveEntryPageCommand ?? new DelegateCommand(MoveDetailPage);
            }
        }
        private DelegateCommand _moveUpdatePageCommand;
        public DelegateCommand MoveUpdatePageCommand
        {
            get
            {
                return this._moveUpdatePageCommand = this._moveUpdatePageCommand ?? new DelegateCommand(MoveDetailPage);
            }
        }

        public InteractionRequest<Notification> NotificationRequest { get; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> ConfirmationRequest { get; } = new InteractionRequest<Confirmation>();

        public InteractionRequest<INotification> SinglePageRequest { get; } = new InteractionRequest<INotification>();
        private DelegateCommand SinglePageCommand { get; set; }
           private DelegateCommand _allSelectChangeCommand;
        public DelegateCommand AllSelectChangeCommand
        {
            get
            {
                return this._allSelectChangeCommand = this._allSelectChangeCommand ?? new DelegateCommand(AllSelectChange);
            }
        }

        #endregion

        #region コンストラクタ
        public AN13020ViewModel() : base()
        {
            ModelObjectMapping();
            ErrorShikiriIchiran();
        }
        #endregion

        #region メソッド

        /// <summary>
        /// エラー仕切一覧検索
        /// </summary>
        private void ErrorShikiriIchiran()
        {
            this.IsLoading = true;

            //テスト用で少し遅らせる
            var task = Task.Run(() =>
            {
                Thread.Sleep(1200);
                this.IsLoading = false;
                this._model.SearchErrorShikiriIchiran();
            });
        }

        /// <summary>
        /// ModelとViewModelを紐づけ
        /// </summary>
        private void ModelObjectMapping()
        {
            this.SelectedShikiri = this._model.ToReactivePropertyAsSynchronized(x => x.SelectedShikiri);
            //this.IsAllSelected = this._model.ToReactivePropertyAsSynchronized(x => x.IsAllSelected);

            this.ShikiriList = this._model.ToReactivePropertyAsSynchronized(x => x.ShikiriList);
            //this.DantaiList = this._model.ObserveProperty(x => x.DantaiList).ToReactiveProperty();
        }

        /// <summary>
        /// 画面をクリア
        /// </summary>
        private void ClearDisplay()
        {
            //this._model.InitializeModelItem();
            this.CheckResult = new CheckResult();
        }

        /// <summary>
        /// 詳細画面遷移
        /// </summary>
        private void MoveDetailPage()
        {
            //this.CheckResult = this._model.ExistDetailData();
            //if (!this._checkResult.IsSuccess) { return; }

            // 検索条件を保持
            AN13020RetentionData.SetValues(this._model);

            var displayMode = new DisplayMode();
            displayMode.SetUpdateMode();

            //this.SinglePageRequest.Raise(new Notification { Title = "　AN22021　団体修正画面", Content = new AN22021ViewModel(displayMode) });
        }

        /// <summary>
        /// グリッドの全選択切替
        /// </summary>
        private void AllSelectChange()
        {
            this._model.ToggleSelect(this.IsAllSelected);
        }

        #endregion

        #region 実装
    

        #endregion

    }

}
