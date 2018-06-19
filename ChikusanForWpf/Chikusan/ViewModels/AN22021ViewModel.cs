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
        //Model
        private AN22021Model _model { get; set; } = new AN22021Model();

        //Property
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
        //public ReactiveProperty<bool> IsStop { get; private set; }

        //Focus
        private bool _isHimmeiCodeFocused;
        public bool IsHimmeiCodeFocused
        {
            get { return _isHimmeiCodeFocused; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeFocused, value);
            }
        }
        private bool _isDantaiNameFocused;
        public bool IsDantaiNameFocused
        {
            get { return _isDantaiNameFocused; }
            set
            {
                this.SetProperty(ref this._isDantaiNameFocused, value);
            }
        }

        //PropertyStatus
        public bool _isHimmeiCodeReadOnly = false;
        public bool IsHimmeiCodeReadOnly
        {
            get { return this._isHimmeiCodeReadOnly; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeReadOnly, value);
            }
        }
        public bool _isDantaiCodeReadOnly = false;
        public bool IsDantaiCodeReadOnly
        {
            get { return this._isDantaiCodeReadOnly; }
            set
            {
                this.SetProperty(ref this._isDantaiCodeReadOnly, value);
            }
        }
        public bool _isCopyButtonEnabled = true;
        public bool IsCopyButtonEnabled
        {
            get { return this._isCopyButtonEnabled; }
            set
            {
                this.SetProperty(ref this._isCopyButtonEnabled, value);
            }
        }
        public bool _isCopyButtonVisible = false;
        public bool IsCopyButtonVisible
        {
            get { return this._isCopyButtonVisible; }
            set
            {
                this.SetProperty(ref this._isCopyButtonVisible, value);
            }
        }
        public bool _isUpdateButtonVisible = false;
        public bool IsUpdateButtonVisible
        {
            get { return this._isUpdateButtonVisible; }
            set
            {
                this.SetProperty(ref this._isUpdateButtonVisible, value);
            }
        }
        public bool _isEntryButtonVisible = false;
        public bool IsEntryButtonVisible
        {
            get { return this._isEntryButtonVisible; }
            set
            {
                this.SetProperty(ref this._isEntryButtonVisible, value);
            }
        }
        public bool _isIconGroupVisible = false;
        public bool IsIconGroupVisible
        {
            get { return this._isIconGroupVisible; }
            set
            {
                this.SetProperty(ref this._isIconGroupVisible, value);
            }
        }
        public bool _isStopIconVisible = false;
        public bool IsStopIconVisible
        {
            get { return this._isStopIconVisible; }
            set
            {
                this.SetProperty(ref this._isStopIconVisible, value);
            }
        }
        public bool _isUseIconVisible = false;
        public bool IsUseIconVisible
        {
            get { return this._isUseIconVisible; }
            set
            {
                this.SetProperty(ref this._isUseIconVisible, value);
            }
        }
        public bool _isCheck = true;
        public bool IsCheck
        {
            get { return this._isCheck; }
            set
            {
                this.SetProperty(ref this._isCheck, value);
            }
        }

        //Commons
        private CheckResult _checkResult;
        public CheckResult CheckResult
        {
            get { return this._checkResult; }
            set
            {
                this.SetProperty(ref this._checkResult, value);
            }
        }
        public DisplayMode DisplayMode { get; set; }

        //Command
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
        private DelegateCommand _updateCommand;
        public DelegateCommand UpdateCommand
        {
            get
            {
                return this._updateCommand = this._updateCommand ?? new DelegateCommand(UpdateDantai);
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

        //Behavior
        public InteractionRequest<Notification> NotificationRequest { get; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> ConfirmationRequest { get; } = new InteractionRequest<Confirmation>();
        public InteractionRequest<INotification> SinglePageRequest { get; } = new InteractionRequest<INotification>();

        #endregion

        #region コンストラクタ
        public AN22021ViewModel(DisplayMode displayMode) : base()
        {
            ModelObjectMapping();
            this.DisplayMode = displayMode;
            SwitchDisplayMode();
        }
        //public AN22021ViewModel(DisplayMode displayMode,DantaiDto dantaiData) : base()
        //{
        //    ModelObjectMapping();
        //    SwitchDisplayMode(displayMode);
        //    this.DisplayMode = displayMode;
        //    this._model.SetRetentionData(dantaiData,displayMode);
        //}
        #endregion

        #region メソッド
        /// <summary>
        /// 団体登録
        /// </summary>
        private void EntryDantai()
        {
            var checkResult = this._model.ExistEntryConditions();
            if (!checkResult.IsSuccess) return;
            checkResult = this._model.EntryDantai();
            this.CheckResult = checkResult;
            //this._model.InitializeModelItem();
            AN22021RetentionData.SetValues(this._model);

            if (this.DisplayMode.IsCopyMode())
            {
                //コピーモード時は詳細画面に遷移
                MoveDetailPage();
            }
            else if (this.DisplayMode.IsEntryMode())
            {
                //登録モード時は初期化
                this._model.InitializeModelItem();
                this.IsHimmeiCodeFocused = true;
            }
        }

        /// <summary>
        /// 団体修正
        /// </summary>
        private void UpdateDantai()
        {
            //チェック
            var checkResult = this._model.ExistEntryConditions();
            if (!checkResult.IsSuccess) return;
            this.CheckResult = checkResult;

            //画面用の停止区分をモデルに反映
            SetStopKubun();

            //修正処理
            this._model.UpdateDantai();
            MoveIchiranPage();

        }
        /// <summary>
        /// ModelとViewModelを紐づけ
        /// </summary>
        private void ModelObjectMapping()
        {
            this.HimmeiCode = this._model.ToReactivePropertyAsSynchronized(x => x.HimmeiCode);
            this.Himmei = this._model.ObserveProperty(x => x.Himmei).ToReactiveProperty();
            this.DantaiCode = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiCode);
            this.DantaiName = this._model.ToReactivePropertyAsSynchronized(x => x.DantaiName);
            this.KoushinshaCode = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaCode);
            this.KoushinshaName = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinshaName);
            this.KoushinDate = this._model.ToReactivePropertyAsSynchronized(x => x.KoushinDate);
            this.IsHimmeiError = this._model.ObserveProperty(x => x.IsHimmeiCodeError).ToReactiveProperty();
            this.IsDantaiCodeError = this._model.ObserveProperty(x => x.IsDantaiCodeError).ToReactiveProperty();
            this.IsDantaiNameError = this._model.ObserveProperty(x => x.IsDantaiNameError).ToReactiveProperty();

        }

        /// <summary>
        /// 画面をクリア
        /// </summary>
        private void ClearDisplay()
        {
            if (this.DisplayMode.IsEntryMode())
            {
                this._model.InitializeModelItem();
                this._model.SetUserInfo();
                this.CheckResult = new CheckResult();
            }
            else if(this.DisplayMode.IsUpdateMode() || this.DisplayMode.IsCopyMode())
            {
                this.SetUpdateRetentionData();
                this.CheckResult = new CheckResult();
            }

            this.IsHimmeiCodeFocused = true;
        }

        /// <summary>
        /// 一覧画面遷移
        /// </summary>
        private void MoveIchiranPage()
        {
            this.SinglePageRequest.Raise(new Notification { Title = "　AN22020 団体マスタメンテナンス＜一覧＞", Content = new AN22020ViewModel() });
        }

        /// <summary>
        /// コピー（登録）画面遷移
        /// </summary>
        private void MoveCopyPage()
        {
            // 検索条件を保持
            //AN22021RetentionData.SetValues( this._model);

            this.DisplayMode.SetCopyMode();
            SwitchDisplayMode();

            //this.SinglePageRequest.Raise(new Notification { Title = "　AN22021　団体登録画面", Content = new AN22021ViewModel(displayMode) });
        }

        /// <summary>
        /// 詳細画面遷移
        /// </summary>
        private void MoveDetailPage()
        {
            this.DisplayMode.SetUpdateMode();
            SwitchUpdateMode();
            SetUpdateRetentionData();
        }

        /// <summary>
        /// 画面の切り替えを行います
        /// </summary>
        private void SwitchDisplayMode()
        {
            if (this.DisplayMode.IsEntryMode())
            {
                SwitchEntryMode();
            }
            else if (this.DisplayMode.IsUpdateMode())
            {
                SwitchUpdateMode();
            }
            else if (this.DisplayMode.IsCopyMode())
            {
                SwitchCopyMode();
            }
        }

        /// <summary>
        /// 登録画面に切り替えます
        /// </summary>
        public void SwitchEntryMode()
        {
            this.IsHimmeiCodeReadOnly = false;
            this.IsDantaiCodeReadOnly = false;
            this.IsCopyButtonVisible = false;
            this.IsUpdateButtonVisible = false;
            this.IsEntryButtonVisible = true;
            this.IsIconGroupVisible = false;
            this.IsHimmeiCodeFocused = true;
            this._model.InitializeModelItem();
            this._model.SetUserInfo();
        }

        /// <summary>
        /// 修正画面に切り替えます
        /// </summary>
        public void SwitchUpdateMode()
        {
            this.IsHimmeiCodeReadOnly = true;
            this.IsDantaiCodeReadOnly = true;
            this.IsCopyButtonVisible = true;
            this.IsCopyButtonEnabled = true;
            this.IsUpdateButtonVisible = true;
            this.IsEntryButtonVisible = false;
            this.IsIconGroupVisible = true;
            this.IsDantaiNameFocused = true;
            this._model.IsStop = false;
            SetBeforeRetentionData();
        }

        /// <summary>
        /// コピー画面に切り替えます
        /// </summary>
        public void SwitchCopyMode()
        {
            this.IsHimmeiCodeReadOnly = false;
            this.IsDantaiCodeReadOnly = false;
            this.IsCopyButtonVisible = true;
            this.IsCopyButtonEnabled = false;
            this.IsUpdateButtonVisible = false;
            this.IsEntryButtonVisible = true;
            this.IsIconGroupVisible = false;
            this._model.IsStop = false;
            this.IsHimmeiCodeFocused = true;
        }

        /// <summary>
        /// 修正画面時の保持データをセットします
        /// </summary>
        private void SetUpdateRetentionData()
        {
            _model.HimmeiCode = AN22021RetentionData.HimmeiCode;
            _model.Himmei = AN22021RetentionData.Himmei;
            _model.DantaiCode = AN22021RetentionData.DantaiCode;
            _model.DantaiName = AN22021RetentionData.DantaiName;
            _model.KoushinshaCode = AN22021RetentionData.KoushinshaCode;
            _model.KoushinshaName = AN22021RetentionData.KoushinshaName;
            _model.KoushinDate = AN22021RetentionData.KoushinDate;
            _model.IsStop = AN22021RetentionData.IsStop;
        }

        /// <summary>
        /// 前の保持データをセットします
        /// </summary>
        private void SetBeforeRetentionData()
        {
            _model.HimmeiCode = AN22020RetentionData.SelectedDantai.HimmeiCode;
            _model.Himmei = AN22020RetentionData.SelectedDantai.Himmei;
            _model.DantaiCode = AN22020RetentionData.SelectedDantai.DantaiCode;
            _model.DantaiName = AN22020RetentionData.SelectedDantai.DantaiName;
            _model.KoushinshaCode = AN22020RetentionData.SelectedDantai.KoushinshaCode;
            _model.KoushinshaName = AN22020RetentionData.SelectedDantai.KoushinshaName;
            _model.KoushinDate = AN22020RetentionData.SelectedDantai.KoushinDateTime.ToShortDateString();
            _model.IsStop = AN22020RetentionData.SelectedDantai.StopKubun == '0' ? false : true;
            if (_model.IsStop)
            {
                this.IsStopIconVisible = true;
                this.IsUseIconVisible = false;
            }
            else
            {
                this.IsUseIconVisible = true;
                this.IsStopIconVisible = false;
            }
        }

        /// <summary>
        /// ストップ区分のセット
        /// </summary>
        private void SetStopKubun()
        {
            if (this.IsStopIconVisible)
            {
                if (this.IsCheck)
                {
                    _model.IsStop = true;
                }
                else
                {
                    _model.IsStop = false;
                }
            }
            else
            {
                if (this.IsCheck)
                {
                    _model.IsStop = false;
                }
                else
                {
                    _model.IsStop = true;
                }
            }
        }

        #endregion

        #region 実装
        #endregion

    }

}
