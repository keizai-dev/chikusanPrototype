using JaGunma.Chikusan.Commons;
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
using Microsoft.Practices.ObjectBuilder2;

namespace JaGunma.Chikusan.Models
{
    public class AN22021Model :BindableBase
    {
        #region メンバ変数

        private string _himmeiCode;
        public string HimmeiCode
        {
            get { return _himmeiCode; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                int paddingCode;
                if (int.TryParse(copyValue, out paddingCode) && paddingCode > 0)
                {
                    // test用
                     this.Himmei = "牛";
                     this.SetProperty(ref this._himmeiCode, paddingCode.ToString("0000"));
                    return;
                }
                this.SetProperty(ref this._himmeiCode, null);
            }
        }
        private string _himmei;
        public string Himmei
        {
            get { return _himmei; }
            set
            {
                this.SetProperty(ref this._himmei, value);
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
        /// 品名コードエラー状態
        /// </summary>
        public bool _isHimmeiCodeError = false;
        public bool IsHimmeiCodeError
        {
            get { return this._isHimmeiCodeError; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeError, value);
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

        /// <summary>
        /// 品名コードフォーカス
        /// </summary>
        private bool _isHimmeiCodeFocused;
        public bool IsHimmeiCodeFocused
        {
            get { return _isHimmeiCodeFocused; }
            set
            {
                this.SetProperty(ref this._isHimmeiCodeFocused, value);
            }
        }

        /// <summary>
        /// 団体コードフォーカス
        /// </summary>
        private bool _isDantaiNameFocused;
        public bool IsDantaiNameFocused
        {
            get { return _isDantaiNameFocused; }
            set
            {
                this.SetProperty(ref this._isDantaiNameFocused, value);
            }
        }
        #endregion

        #region コンストラクタ
        public AN22021Model()
        {

        }
        #endregion

        #region メソッド

        /// <summary>
        /// 登録時の入力状態を返却
        /// </summary>
        /// <returns></returns>
        public CheckResult ExistEntryConditions()
        {
            var result = new CheckResult();
            if (this.InputHimmeiCode(result).IsSuccess) { return result; }
            if (this.InputDantaiCode(result).IsSuccess) { return result; }
            if (this.InputDantaiName(result).IsSuccess) { return result; }
            return result;
        }

        /// <summary>
        /// 品名コード入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputHimmeiCode(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.HimmeiCode))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "品名コード");
                checkResult.SetWarningType();
                this.IsHimmeiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
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
        /// モデル値を初期化
        /// </summary>
        public void InitializeModelItem()
        {
            this.DantaiCode = string.Empty;
            this.DantaiName = string.Empty;
            this.KoushinDate = DateTime.Now.ToShortDateString(); ;
            this.KoushinDateStart = string.Empty;
            this.KoushinDateEnd = string.Empty;
            this.IsStop = true;
            this.SelectedDantai = null;
            this.HimmeiCode = string.Empty;
            this.Himmei = string.Empty;
            this.IsHimmeiCodeError = false;
            this._isHimmeiCodeFocused = true;
        }

        /// <summary>
        /// 団体を登録
        /// </summary>
        public CheckResult EntryDantai()
        {
            AN22020RetentionData.DantaiDataList.Add(new DantaiDto()
            {
                HimmeiCode = this.HimmeiCode,
                Himmei = this.Himmei,
                DantaiCode = this._dantaiCode,
                DantaiName = this._dantaiName,
                KoushinDateTime = DateTime.Now,
                KoushinshaCode = this._koushinshaCode,
                KoushinshaName = this._koushinshaName,
                StopKubun = '0'
                //StopKubun = this._stopKubun,
            });

            var result = new CheckResult();
            result.SetSuccessType();
            result.Message = MessageConstants.INFO_MESSAGE_001.Replace("{0}","団体登録");
            return result;
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
                    x.StopKubun = this.IsStop ? '1' : '0'; x.DantaiName = this.DantaiName; x.KoushinDateTime = DateTime.Now; x.KoushinshaCode = HeaderRetentionData.UserID; x.KoushinshaName = HeaderRetentionData.UserName;
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

        #endregion

    }
}
