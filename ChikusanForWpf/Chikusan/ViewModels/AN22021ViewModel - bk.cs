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
using JaGunma.Chikusan.RetentionData;
using JaGunma.Chikusan.Message;

namespace JaGunma.Chikusan.ViewModels
{
        public class AN22021ViewModel : AbstractViewModel
    {

        #region メンバ変数
        //private AN22021Model _model { get; set; } = new AN22021Model();
        private DantaiModel _model { get; set; } = new DantaiModel(new HimmeiModel());

        private bool _isHimmeiCodeFocused;
        public bool IsHimmeiCodeFocused
        {
            get { return _isHimmeiCodeFocused; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeFocused, value);
            }
        }
        public ReactiveProperty<bool> IsHimmeiError { get; private set; }
        public ReactiveProperty<bool> IsDantaiCodeError { get; private set; }
        public ReactiveProperty<bool> IsDantaiNameError { get; private set; }
        public ReactiveProperty<string> HimmeiCode { get; private set; }
        public ReactiveProperty<string> Himmei { get; private set; }
        public ReactiveProperty<string> DantaiCode { get; private set; }
        public ReactiveProperty<string> DantaiName { get; private set; }
        public ReactiveProperty<string> KoushinshaCode { get; private set; }
        public ReactiveProperty<string> KoushinshaName { get; private set; }
        public ReactiveProperty<string> KoushinDate { get; private set; }
        public ReactiveProperty<bool> IsStop { get; private set; }
        public ReactiveProperty<bool> IsError { get; private set; }

        public bool _isUpdateMode = false;
        public bool IsUpdateMode
        {
            get { return this._isUpdateMode; }
            set
            {
                this.SetProperty(ref this._isUpdateMode, value);
            }
        }
        public bool _isEntryMode = false;
        public bool IsEntryMode
        {
            get { return this._isEntryMode; }
            set
            {
                this.SetProperty(ref this._isEntryMode, value);
            }
        }
        public bool _isCopyMode = false;
        public bool IsCopyMode
        {
            get { return this._isCopyMode; }
            set
            {
                this.SetProperty(ref this._isCopyMode, value);
            }
        }
        private CheckResult _checkResult;
        public CheckResult CheckResult
        {
            get { return this._checkResult; }
            set
            {
                this.SetProperty(ref this._checkResult, value);
            }
        }
        private bool _isHimmeiCodeStartFocused;
        public bool IsHimmeiCodeStartFocused
        {
            get { return _isHimmeiCodeStartFocused; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeStartFocused, value);
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

        private DelegateCommand _entryCommand;
        public DelegateCommand EntryCommand
        {
            get
            {
                return this._entryCommand = this._entryCommand ?? new DelegateCommand(EntryDantai);
            }
        }
        private DelegateCommand _moveIchiranPageCommand;
        public DelegateCommand MoveIchiranPageCommand
        {
            get
            {
                return this._moveIchiranPageCommand = this._moveIchiranPageCommand ?? new DelegateCommand(MoveIchiranPage);
            }
        }
        private DelegateCommand _moveCopyPageCommand;
        public DelegateCommand MoveCopyPageCommand
        {
            get
            {
                return this._moveCopyPageCommand = this._moveCopyPageCommand ?? new DelegateCommand(MoveCopyPage);
            }
        }

        public InteractionRequest<Notification> NotificationRequest { get; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> ConfirmationRequest { get; } = new InteractionRequest<Confirmation>();

        public InteractionRequest<INotification> SinglePageRequest { get; } = new InteractionRequest<INotification>();
        private DelegateCommand SinglePageCommand { get; set; }

        #endregion

        #region コンストラクタ
        public AN22021ViewModel(DisplayMode displayMode) : base()
        {
            ModelObjectMapping();
            this._model.SetRetentionData(displayMode);
            SwitchDisplayMode(displayMode);
        }
        public AN22021ViewModel(DisplayMode displayMode,DantaiDto dantaiData) : base()
        {
            ModelObjectMapping();
            SwitchDisplayMode(displayMode);
            this._model.SetRetentionData(dantaiData,displayMode);
        }
        #endregion

        #region メソッド
        /// <summary>
        /// 団体登録
        /// </summary>
        private void EntryDantai()
        {
            var checkResult = this._model.ExistEntryConditions();
            if (!checkResult.IsSuccess) return;
            this.CheckResult = checkResult;
            this._model.EntryDantai();
            this._model.InitializeModelItem();

        }

        /// <summary>
        /// ModelとViewModelを紐づけ
        /// </summary>
        private void ModelObjectMapping()
        {
            this.HimmeiCode = this._model.Himmei.ToReactivePropertyAsSynchronized(x => x.HimmeiCode);
            this.Himmei = this._model.Himmei.ObserveProperty(x => x.Himmei).ToReactiveProperty();
            this.DantaiCode = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiCode);
            this.DantaiName = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiName);
            this.KoushinshaCode = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaCode);
            this.KoushinshaName = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaName);
            this.KoushinDate = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinDate);
            //this.VisibleNormalIcon = this._model.ToReactivePropertyAsSynchronized(x => x.VisibleNormalIcon);
            //this.VisibleStopIcon = this._model.ToReactivePropertyAsSynchronized(x => x.VisibleStopIcon);
            this.IsStop = this._model.ToReactivePropertyAsSynchronized(x => x.IsStop);
            //this.IsEntryMode = this._model.ObserveProperty(x => x.IsEntryMode).ToReactiveProperty();
            //this.IsUpdateMode = this._model.ObserveProperty(x => x.IsUpdateMode).ToReactiveProperty();
            this.IsHimmeiError = this._model.ObserveProperty(x => x.Himmei.IsHimmeiError).ToReactiveProperty();
            this.IsDantaiCodeError = this._model.ObserveProperty(x => x.IsDantaiCodeError).ToReactiveProperty();
            this.IsDantaiNameError = this._model.ObserveProperty(x => x.IsDantaiNameError).ToReactiveProperty();

        }

        /// <summary>
        /// 画面をクリア
        /// </summary>
        private void ClearDisplay()
        {
            this._model.InitializeModelItem();

            this.IsHimmeiCodeFocused = true;
        }

        /// <summary>
        /// 一覧画面遷移
        /// </summary>
        private void MoveIchiranPage()
        {
            this.SinglePageRequest.Raise(new Notification { Title = "　AN22020 団体一覧", Content = new AN22020ViewModel() });
        }

        /// <summary>
        /// コピー（登録）画面遷移
        /// </summary>
        private void MoveCopyPage()
        {
            // 検索条件を保持
           AN22021RetentionData.SetValues( this._model);

            var displayMode = new DisplayMode();
            displayMode.SetEntryMode();
            this.SinglePageRequest.Raise(new Notification { Title = "　AN22021　団体登録画面", Content = new AN22021ViewModel(displayMode) });
        }

        /// <summary>
        /// 画面モードを判断します
        /// </summary>
        public void SwitchDisplayMode(DisplayMode displayMode)
        {
            if (displayMode.IsUpdateMode())
            {
                this.IsUpdateMode = true;
                this.IsEntryMode = false;
            }
            else if (displayMode.IsEntryMode())
            {
                this.IsEntryMode = true;
                this.IsUpdateMode = false;
                _model.SetUserInfo();
            }
        }

        #endregion

        #region 実装
        #endregion

    }

}
