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

namespace JaGunma.Chikusan.Models
{
    public class HimmeiModel :BindableBase
    {
        #region メンバ変数

        /// <summary>
        /// 品名コード開始
        /// </summary>
        private string _himmeiCodeStart;
        public string HimmeiCodeStart
        {
            get { return _himmeiCodeStart; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                int paddingCode;
                if (int.TryParse(copyValue, out paddingCode) && paddingCode > 0)
                {
                    this.SetProperty(ref this._himmeiCodeStart, paddingCode.ToString("0000"));
                    return;
                }
                this.SetProperty(ref this._himmeiCodeStart, null);
            }
        }

        /// <summary>
        /// 品名コード終了
        /// </summary>
        private string _himmeiCodeEnd;
        public string HimmeiCodeEnd
        {
            get { return _himmeiCodeEnd; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                int paddingCode;
                if (int.TryParse(copyValue, out paddingCode) && paddingCode > 0)
                {
                     this.SetProperty(ref this._himmeiCodeEnd, paddingCode.ToString("0000"));
                    return;
                }
                this.SetProperty(ref this._himmeiCodeEnd, null);
            }
        }

        /// <summary>
        /// 品名コード
        /// </summary>
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

        /// <summary>
        /// 品名
        /// </summary>
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
        /// 品名エラー状態
        /// </summary>
        public bool _isHimmeiError = false;
        public bool IsHimmeiError
        {
            get { return this._isHimmeiError; }
            set
            {
                this.SetProperty(ref this._isHimmeiError, value);
            }
        }
        #endregion

        #region コンストラクタ
        public HimmeiModel()
        {

        }
        #endregion

        #region メソッド

        /// <summary>
        /// 検索条件の入力状態を返却
        /// </summary>
        /// <returns></returns>
        public CheckResult ExistSearchConditions()
        {
            var result = new CheckResult();
            if (!string.IsNullOrEmpty(this.HimmeiCodeStart)) { return result; }
            if (!string.IsNullOrEmpty(this.HimmeiCodeEnd)) { return result; }
            if (!string.IsNullOrEmpty(this.Himmei)) { return result; }
            result.SetWarningType();
            return result;
        }

        /// <summary>
        /// モデル値を初期化
        /// </summary>
        public void InitializeModelItem()
        {
            this.HimmeiCodeStart = string.Empty;
            this.HimmeiCodeEnd = string.Empty;
            this.HimmeiCode = string.Empty;
            this.Himmei = string.Empty;
            this.IsHimmeiError = false;
        }

        /// <summary>
        /// 検索条件を保持します
        /// </summary>
        public void SaveConditions()
        {
            AN22020RetentionData.HimmeiCodeStart = this._himmeiCodeStart;
            AN22020RetentionData.HimmeiCodeEnd = this._himmeiCodeEnd;
            AN22020RetentionData.Himmei = this._himmei;
        }

        /// <summary>
        /// 保持された条件をセットします
        /// </summary>
        public void SetSaveData()
        {
            this.HimmeiCodeStart = AN22020RetentionData.HimmeiCodeStart;
            this.HimmeiCodeEnd = AN22020RetentionData.HimmeiCodeEnd;
            this.Himmei = AN22020RetentionData.Himmei;
        }

        /// <summary>
        /// 品名コード入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputHimmeiCode(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.HimmeiCode))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}","品名コード");
                checkResult.SetWarningType();
                this.IsHimmeiCodeError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
         }

        /// <summary>
        /// 品名コード開始入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputHimmeiCodeStart(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.HimmeiCodeStart))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "品名コード開始");
                checkResult.SetWarningType();
                this.IsHimmeiError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 品名コード終了入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputHimmeiCodeEnd(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.HimmeiCodeEnd))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "品名コード終了");
                checkResult.SetWarningType();
                this.IsHimmeiError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        /// <summary>
        /// 品名入力チェック
        /// </summary>
        /// <returns></returns>
        public CheckResult InputHimmei(CheckResult checkResult)
        {
            if (string.IsNullOrEmpty(this.Himmei))
            {
                checkResult.Message = MessageConstants.WARNING_MESSAGE_001.Replace("{0}", "品名");
                checkResult.SetWarningType();
                this.IsHimmeiError = true;
                return checkResult;
            }
            checkResult.SetSuccessType();
            return checkResult;
        }

        #endregion

    }
}
