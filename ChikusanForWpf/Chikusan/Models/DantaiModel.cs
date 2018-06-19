using JaGunma.Chikusan.DataModels;
using JaGunma.Chikusan.RetentionData;
using JaGunma.Chikusan.Message;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Practices.ObjectBuilder2;
using JaGunma.Chikusan.Commons;

namespace JaGunma.Chikusan.Models
{
    public class DantaiModel :BindableBase
    {
        #region メンバ変数
        /// <summary>
        /// 団体リスト
        /// </summary>
        private ObservableCollection<DantaiDto> _dantaiList = new ObservableCollection<DantaiDto>();
        public ObservableCollection<DantaiDto> DantaiList
        {
           get { return this._dantaiList; }
           set
            {
               this.SetProperty(ref this._dantaiList, value);
            }
        }
        /// <summary>
        /// 団体コード開始
        /// </summary>
        private string _dantaiCodeStart;
        public string DantaiCodeStart
        {
            get { return this._dantaiCodeStart; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                int paddingCode;
                if (int.TryParse(copyValue, out paddingCode) && paddingCode > 0)
                {
                    this.SetProperty(ref this._dantaiCodeStart, paddingCode.ToString("000"));
                    return;
                }
                this.SetProperty(ref this._dantaiCodeStart, null);
            }
        }
        /// <summary>
        /// 団体コード終了
        /// </summary>
        private string _dantaiCodeEnd;
        public string DantaiCodeEnd
        {
            get { return this._dantaiCodeEnd; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                int paddingCode;
                if (int.TryParse(copyValue, out paddingCode) && paddingCode > 0)
                {
                    this.SetProperty(ref this._dantaiCodeEnd, paddingCode.ToString("000"));
                    return;
                }
                this.SetProperty(ref this._dantaiCodeEnd, null);
            }
        }

        /// <summary>
        /// 団体コード
        /// </summary>
        private string _dantaiCode;
        public string DantaiCode
        {
            get { return this._dantaiCode; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                int paddingCode;
                if (int.TryParse(copyValue, out paddingCode) && paddingCode > 0)
                {
                    this.SetProperty(ref this._dantaiCode, paddingCode.ToString("000"));
                    return;
                }
                this.SetProperty(ref this._dantaiCode, null);
            }
        }

        /// <summary>
        /// 団体名
        /// </summary>
        private string _dantaiName;
        public string DantaiName
        {
            get { return this._dantaiName; }
            set
            {
               this.SetProperty(ref this._dantaiName, value);
            }
        }
        /// <summary>
        /// 更新者コード
        /// </summary>
        private string _koushinshaCode;
        public string KoushinshaCode
        {
            get { return this._koushinshaCode; }
            set
            {
                this.SetProperty(ref this._koushinshaCode, value);
            }
        }
        /// <summary>
        /// 更新者名
        /// </summary>
        private string _koushinshaName;
        public string KoushinshaName
        {
            get { return this._koushinshaName; }
            set
            {
                this.SetProperty(ref this._koushinshaName, value);
            }
        }

        /// <summary>
        /// 更新日
        /// </summary>
        private string _koushinDate = DateTime.Now.ToShortDateString();
        public string KoushinDate
        {
            get { return this._koushinDate; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                DateTime formatDate;
                if (DateTime.TryParseExact(copyValue, "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out formatDate))
                {
                    this.SetProperty(ref this._koushinDate, formatDate.ToShortDateString());
                    return;
                }

                if (DateTime.TryParseExact(copyValue, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out formatDate))
                {
                    this.SetProperty(ref this._koushinDate, formatDate.ToShortDateString());
                    return;
                }
                this.SetProperty(ref this._koushinDate, value);
                this.SetProperty(ref this._koushinDate, string.Empty);
            }
        }
        /// <summary>
        /// 更新日開始
        /// </summary>
        private string _koushinDateStart;
        public string KoushinDateStart
        {
            get { return this._koushinDateStart; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                DateTime formatDate;
                if (DateTime.TryParseExact(copyValue, "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out formatDate))
                {
                    this.SetProperty(ref this._koushinDateStart, formatDate.ToShortDateString());
                    return;
                }

                if (DateTime.TryParseExact(copyValue, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out formatDate))
                {
                    this.SetProperty(ref this._koushinDateStart, formatDate.ToShortDateString());
                    return;
                }
                this.SetProperty(ref this._koushinDateStart, copyValue);
                this.SetProperty(ref this._koushinDateStart, string.Empty);
            }
        }
        /// <summary>
        /// 更新日終了
        /// </summary>
        private string _koushinDateEnd;
        public string KoushinDateEnd
        {
            get { return this._koushinDateEnd; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                DateTime formatDate;
                if (DateTime.TryParseExact(copyValue, "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out formatDate))
                {
                    this.SetProperty(ref this._koushinDateEnd, formatDate.ToShortDateString());
                    return;
                }

                if (DateTime.TryParseExact(copyValue, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out formatDate))
                {
                    this.SetProperty(ref this._koushinDateEnd, formatDate.ToShortDateString());
                    return;
                }
                //不整値を毎回入力されると変更通知が走らない対応
                this.SetProperty(ref this._koushinDateEnd, copyValue);
                this.SetProperty(ref this._koushinDateEnd, null);
            }
        }
        /// <summary>
        /// 停止状態
        /// </summary>
        private bool _isStop = true;
        public bool IsStop
        {
            get { return this._isStop; }
            set
            {
                this.SetProperty(ref this._isStop, value);
            }
        }
        /// <summary>
        /// 選択団体
        /// </summary>
        private DantaiDto _selectedDantai;
        public DantaiDto SelectedDantai
        {
            get { return _selectedDantai; }
            set
            {
                this.SetProperty(ref this._selectedDantai, value);
            }
        }
        /// <summary>
        /// 品名
        /// </summary>
        private HimmeiModel _himmei;
        public HimmeiModel Himmei
        {
            get { return this._himmei; }
            set
            {
                this.SetProperty(ref this._himmei, value);
            }
        }

        /// <summary>
        /// 団体コードエラー状態
        /// </summary>
        public bool _isDantaiCodeError = false;
        public bool IsDantaiCodeError
        {
            get { return this._isDantaiCodeError; }
            set
            {
                this.SetProperty(ref this._isDantaiCodeError, value);
            }
        }

        /// <summary>
        /// 団体名開始エラー状態
        /// </summary>
        public bool _isDantaiNameError = false;
        public bool IsDantaiNameError
        {
            get { return this._isDantaiNameError; }
            set
            {
                this.SetProperty(ref this._isDantaiNameError, value);
            }
        }


        #endregion

        #region コンストラクタ
        public DantaiModel(HimmeiModel himmeiModel)
        {
            this.Himmei = himmeiModel;
        }
        #endregion

        #region メソッド
        /// <summary>
        ///  団体一覧を取得
        /// </summary>
        /// <returns>団体一覧</returns>
        public void SearchDantaiIchiran()
        {
            this.DantaiList = new ObservableCollection<DantaiDto>(DantaiDto.GetTestData());
            //this.DantaiList = new List<DantaiDto>(DantaiDto.GetTestData());
            if (this.DantaiList.Count > 0)
            {
                this.SelectedDantai = this.DantaiList[0];
            }
        }

        /// <summary>
        /// 団体一覧検索条件の入力状態を返却
        /// </summary>
        /// <returns></returns>
        public CheckResult ExistSearchConditions()
        {
            var result = new CheckResult();
            if (this.Himmei.InputHimmeiCodeStart(result).IsSuccess) { return result; }
            if (this.Himmei.InputHimmeiCodeEnd(result).IsSuccess) { return result; }
            if (this.InputDantaiCodeStart(result).IsSuccess) { return result; }
            if (this.InputDantaiCodeEnd(result).IsSuccess) { return result; }
            if (this.InputDantaiName(result).IsSuccess) { return result; }
            if (this.InputKoushinshaCode(result).IsSuccess) { return result; }
            if (this.InputKoushinshaName(result).IsSuccess) { return result; }
            if (this.InputKoushinDateStart(result).IsSuccess) { return result; }
            if (this.InputKoushinDateEnd(result).IsSuccess) { return result; }
            result.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}","検索条件");
            result.SetWarningType();
            return result;
        }

        /// <summary>
        /// 登録時の入力状態を返却
        /// </summary>
        /// <returns></returns>
        public CheckResult ExistEntryConditions()
        {
            var result = new CheckResult();
            if (this.Himmei.InputHimmeiCode(result).IsSuccess) { return result; }
            if (this.InputDantaiCode(result).IsSuccess) { return result; }
            if (this.InputDantaiName(result).IsSuccess) { return result; }
            return result;
        }

        /// <summary>
        /// 検索条件の入力状態を返却
        /// </summary>
        /// <returns></returns>
        public CheckResult ExistDetailData()
        {
            var result = new CheckResult();
            if (this.DantaiList.Count > 0) { return result; }
            result.Message = MessageConstants.WARNING_MESSAGE_002.Replace("{0}","団体");
            result.SetWarningType();
            return result;
        }

        /// <summary>
        /// 団体コード入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputDantaiCode(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.DantaiCode))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "団体コード");
                checkResult.SetWarningType();
                this.IsDantaiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 団体コード開始入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputDantaiCodeStart(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.DantaiCodeStart))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "団体コード開始");
                checkResult.SetWarningType();
                this.IsDantaiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 団体コード終了入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputDantaiCodeEnd(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.DantaiCodeEnd))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "団体コード終了");
                checkResult.SetWarningType();
                this.IsDantaiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 団体名入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputDantaiName(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.DantaiName))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "団体コード");
                checkResult.SetWarningType();
                this.IsDantaiNameError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 更新者コード入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputKoushinshaCode(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.KoushinshaCode))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "更新者コード");
                checkResult.SetWarningType();
                //this.IsDantaiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 更新者名入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputKoushinshaName(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.KoushinshaName))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "更新者名");
                checkResult.SetWarningType();
                //this.IsDantaiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 更新日開始入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputKoushinDateStart(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.KoushinDateStart))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "更新日開始");
                checkResult.SetWarningType();
                //this.IsDantaiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 更新日終了入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputKoushinDateEnd(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.KoushinDateEnd))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "更新日終了");
                checkResult.SetWarningType();
                //this.IsDantaiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 片側入力補完
        /// </summary>
        public void OtherCompletion()
        {
            //品名コード
            if (string.IsNullOrEmpty(this.Himmei.HimmeiCodeStart))
            {
                this.Himmei.HimmeiCodeStart = this.Himmei.HimmeiCodeEnd;
            }
            else if (string.IsNullOrEmpty(this.Himmei.HimmeiCodeEnd))
            {
                this.Himmei.HimmeiCodeEnd = this.Himmei.HimmeiCodeStart;
            }
            //団体コード
            if (string.IsNullOrEmpty(this.DantaiCodeStart))
            {
                this.DantaiCodeStart = this.DantaiCodeEnd;
            }
            else if (string.IsNullOrEmpty(this.DantaiCodeEnd))
            {
                this.DantaiCodeEnd = this.DantaiCodeStart;
            }
            //更新日
            if (string.IsNullOrEmpty(this.KoushinDateStart))
            {
                this.KoushinDateStart = this.KoushinDateEnd;
            }
            else if (string.IsNullOrEmpty(this.KoushinDateEnd))
            {
                this.KoushinDateEnd = this.KoushinDateStart;
            }
        }

        /// <summary>
        /// モデル値を初期化
        /// </summary>
        public void InitializeModelItem()
        {
            this.DantaiCodeStart = string.Empty;
            this.DantaiCodeEnd = string.Empty;
            this.DantaiCode = string.Empty;
            this.DantaiName = string.Empty;
            this.KoushinDate = DateTime.Now.ToShortDateString(); ;
            this.KoushinDateStart = string.Empty ;
            this.KoushinDateEnd = string.Empty;
            this.IsStop = true;
            this.DantaiList = new ObservableCollection<DantaiDto>();
            this.SelectedDantai =null;
            this.Himmei.InitializeModelItem();
        }

        /// <summary>
        /// 団体を登録
        /// </summary>
        public void EntryDantai()
        {
            AN22020RetentionData.DantaiDataList.Add(new DantaiDto()
            {
                HimmeiCode = this._himmei.HimmeiCode,
                Himmei = this._himmei.Himmei,
                DantaiCode = this._dantaiCode,
                DantaiName = this._dantaiName,
                KoushinDateTime = DateTime.Now,
                KoushinshaCode = this._koushinshaCode,
                KoushinshaName = this._koushinshaName
                //StopKubun = this._stopKubun,
            });
        }


        /// <summary>
        /// 団体を修正
        /// </summary>
        public void UpdateDantai()
        {
            AN22020RetentionData.DantaiDataList
                .Where(x => x.DantaiCode == this.DantaiCode)
                .ForEach(x => 
                {
                    x.StopKubun = this.IsStop ? '1' : '0' ; x.DantaiName = this.DantaiName;x.KoushinDateTime = DateTime.Now;x.KoushinshaCode = HeaderRetentionData.UserID; x.KoushinshaName = HeaderRetentionData.UserName;
                });
        }

        /// <summary>
        /// ユーザ情報をセット
        /// </summary>
        public void SetUserInfo()
        {
            this.KoushinshaCode = HeaderRetentionData.UserID;
            this.KoushinshaName = HeaderRetentionData.UserName;
        }

        /// <summary>
        /// データグリッドの選択トグル操作
        /// </summary>
        /// <param name="isAllSelected"></param>
        public void ToggleSelect(bool isAllSelected)
        {
            if (isAllSelected)
            {
                this.DantaiList.ForEach(x => x.IsSelected = true);
            }
            else
            {
                this.DantaiList.ForEach(x => x.IsSelected = false);
            }
            this.DantaiList = new ObservableCollection<DantaiDto>(this.DantaiList);
        }

        #endregion

    }
}
