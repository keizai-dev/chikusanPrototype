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
        public class AN22020ViewModel : AbstractViewModel
    {

        #region メンバ変数
        private AN22020Model _model { get; set; } = new AN22020Model();

        private bool _isHimmeiCodeStartFocused;
           public bool IsHimmeiCodeStartFocused
        {
            get { return _isHimmeiCodeStartFocused; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeStartFocused, value);
            }
        }
        public ReactiveProperty<string> HimmeiCodeStart { get; private set; }
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

        public ReactiveProperty<DantaiDto> SelectedDantai { get; private set; }
        public ReactiveProperty<ObservableCollection<DantaiDto>> DantaiList { get; private set; }
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
        //public ReactiveProperty<bool> IsAllSelected { get; private set; }

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
        private DelegateCommand _moveUpdatePageCommand;
        public DelegateCommand MoveUpdatePageCommand
        {
            get
            {
                return this._moveUpdatePageCommand = this._moveUpdatePageCommand ?? new DelegateCommand(MoveUpdatePage);
            }
        }

        public InteractionRequest<Notification> NotificationRequest { get; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> ConfirmationRequest { get; } = new InteractionRequest<Confirmation>();

        public InteractionRequest<INotification> SinglePageRequest { get; } = new InteractionRequest<INotification>();
        private DelegateCommand SinglePageCommand { get; set; }
        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand
        {
            get
            {
                return this._testCommand = this._testCommand ?? new DelegateCommand(Test);
            }
        }
        private DelegateCommand _dataOutputCommand;
        public DelegateCommand DataOutputCommand
        {
            get
            {
                return this._dataOutputCommand = this._dataOutputCommand ?? new DelegateCommand(DataOutput);
            }
        }
        private DelegateCommand _allSelectChangeCommand;
        public DelegateCommand AllSelectChangeCommand
        {
            get
            {
                return this._allSelectChangeCommand = this._allSelectChangeCommand ?? new DelegateCommand(AllSelectChange);
            }
        }
        private DelegateCommand _checkCommand;
        public DelegateCommand CheckCommand
        {
            get
            {
                return this._checkCommand = this._checkCommand ?? new DelegateCommand(EmptySelect);
            }
        }
        private DelegateCommand _showHimmeiSearchCommand;
        public DelegateCommand ShowHimmeiSearchCommand
        {
            get
            {
                return this._showHimmeiSearchCommand = this._showHimmeiSearchCommand ?? new DelegateCommand(ShowHimmeiSearch);
            }
        }

        #endregion

        #region コンストラクタ
        //public AN22020ViewModel(RegionManager regionManager) : base() {
        //    this.RegionManager = regionManager;
        //    ModelObjectMapping();
        //}
        public AN22020ViewModel() : base()
        {
            SetRetentionData();
            ModelObjectMapping();

        }
        #endregion

        #region メソッド
        /// <summary>
        /// 画面保持データをセット
        /// </summary>
        private void SetRetentionData()
        {
            _model.HimmeiCodeStart = AN22020RetentionData.HimmeiCodeStart;
            _model.HimmeiCodeEnd = AN22020RetentionData.HimmeiCodeEnd;
            _model.Himmei = AN22020RetentionData.Himmei;
            _model.DantaiCodeStart = AN22020RetentionData.DantaiCodeStart;
            _model.DantaiCodeEnd = AN22020RetentionData.DantaiCodeEnd;
            _model.DantaiName = AN22020RetentionData.DantaiName;
            _model.DantaiList = new ObservableCollection<DantaiDto>(AN22020RetentionData.DantaiDataList);
            _model.SelectedDantai = AN22020RetentionData.SelectedDantai;
        }

        /// <summary>
        /// 団体一覧検索
        /// </summary>
        private void SearchDantaiIchiran()
        {
            this.IsLoading = true;

            var result = this._model.ExistSearchConditions();
            if (!result.IsSuccess) 
            {
                this.IsHimmeiCodeStartFocused = true;
                this.CheckResult = result;
                this.IsLoading = false;
                return;
            }
            this.CheckResult = new CheckResult();

            //片方入力補完
            this._model.OtherCompletion();

            //テスト用で少し遅らせる
            var task = Task.Run(() =>
            {
                Thread.Sleep(1200);
                this.IsLoading = false;
                this._model.SearchDantaiIchiran();
            });
        }

        /// <summary>
        /// ModelとViewModelを紐づけ
        /// </summary>
        private void ModelObjectMapping()
        {
            this.HimmeiCodeStart = this._model.ToReactivePropertyAsSynchronized(x => x.HimmeiCodeStart);
            this.HimmeiCodeEnd = this._model.ToReactivePropertyAsSynchronized(x => x.HimmeiCodeEnd);
            this.Himmei = this._model.ToReactivePropertyAsSynchronized(x => x.Himmei);
            this.DantaiCodeStart = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiCodeStart);
            this.DantaiCodeEnd = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiCodeEnd);
            this.DantaiName = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiName);
            this.KoushinshaCode = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaCode);
            this.KoushinshaName = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaName);
            this.KoushinDateStart = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinDateStart);
            this.KoushinDateEnd = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinDateEnd);
            this.IsStop = this._model.ToReactivePropertyAsSynchronized(x => x.IsStop);
            this.SelectedDantai = this._model.ToReactivePropertyAsSynchronized(x => x.SelectedDantai);
            //this.IsAllSelected = this._model.ToReactivePropertyAsSynchronized(x => x.IsAllSelected);

            this.DantaiList = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiList);
            //this.DantaiList = this._model.ObserveProperty(x => x.DantaiList).ToReactiveProperty();
        }

        /// <summary>
        /// 画面をクリア
        /// </summary>
        private void ClearDisplay()
        {
            this._model.InitializeModelItem();
            this.CheckResult = new CheckResult();
            this.IsHimmeiCodeStartFocused = true;
        }

        /// <summary>
        /// 登録画面遷移
        /// </summary>
        private void MoveEntryPage()
        {
            //this.NewPageRequest.Raise(new Notification(), new Action<INotification>(x => { }));
            // 検索条件を保持
            AN22020RetentionData.SetValues(this._model);

            var displayMode = new DisplayMode();
            displayMode.SetEntryMode();
            this.SinglePageRequest.Raise(new Notification { Title = "　AN22021　団体マスタメンテナンス", Content = new AN22021ViewModel(displayMode)});
            //this.RegionManager.RequestNavigate("MainRegion", nameof(Views.CalcResultView));

        }

        /// <summary>
        /// 修正画面遷移
        /// </summary>
        private void MoveUpdatePage()
        {
            //this.NewPageRequest.Raise(new Notification(), new Action<INotification>(x => { }));
            this.CheckResult = this._model.ExistDetailData();
            if (!this._checkResult.IsSuccess) { return; }

            // 検索条件を保持
            AN22020RetentionData.SetValues(this._model);

            var displayMode = new DisplayMode();
            displayMode.SetUpdateMode();
            //_model.SetRetentionData(this.SelectedDantai.Value,displayMode);
            this.SinglePageRequest.Raise(new Notification { Title = "　AN22021　団体マスタメンテナンス", Content = new AN22021ViewModel(displayMode) });
            //this.RegionManager.RequestNavigate("MainRegion", nameof(Views.CalcResultView));

        }

        /// <summary>
        /// 品名検索画面
        /// </summary>
        private void ShowHimmeiSearch()
        {
            var parameter = new HimmeiSearchParameter();
            parameter.HimmeiCodeStart = this.HimmeiCodeStart.Value;
            parameter.HimmeiCodeEnd = this.HimmeiCodeStart.Value;
            parameter.Himmei =this.Himmei.Value;
            var result = DialogMessenger.Show(parameter);
            _model.HimmeiCodeStart = result.HimmeiCode;
            _model.HimmeiCodeEnd = result.HimmeiCode;
            _model.Himmei = result.Himmei;
        }

        /// <summary>
        /// データ出力
        /// </summary>
        private void DataOutput()
        {
            var result = DialogMessenger.Show(new FileSaveParameter());
            if (result.Result) { }
        }

        /// <summary>
        /// グリッドの全選択切替
        /// </summary>
        private void AllSelectChange()
        {
            this._model.ToggleSelect(this.IsAllSelected);
        }

        /// <summary>
        /// 選択団体を空にする
        /// </summary>
        private void EmptySelect()
        {
            this._model.SelectedDantai = null;
        }

        private void Test()
        {
            var parameter = new DialogParameter();
            parameter.SetIconQuestion();
            parameter.SetTypeYesNo();
            parameter.Message = MessageConstants.WARNING_MESSAGE_002.Replace("{0}", "( ^)o(^ )");
            DialogMessenger.Show(parameter);
            //var test = DialogMessenger.Show(new FileSaveParameter());
            //if (test.Result) { }

        }
        #endregion

        #region 実装
    

        #endregion

    }

}
