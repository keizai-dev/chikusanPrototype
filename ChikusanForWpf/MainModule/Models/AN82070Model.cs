using JaGunma.MainModule.DataModels;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.MainModule.Models
{
    public class AN82070Model :BindableBase
    {
        #region メンバ変数
        private string _himmeiCodeStart;
        public string HimmeiCodeStart
        {
            get { return _himmeiCodeStart; }
            set
            {
                if (value == null) return;
                var copyValue = string.Copy(value);
                //var copyValue = "";
                    var aa = copyValue.Substring(10, 500);

                int paddingCode;
                if (int.TryParse(copyValue, out paddingCode) && paddingCode > 0)
                {
                    this._himmeiCodeStart = paddingCode.ToString("0000");
                    return;
                }
                this._himmeiCodeStart = null;
                //this.SetProperty(ref this._himmeiCodeStart, paddingCode);
                //this.ValidateProperty(value);
            }
        }

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
        private string _himmei;
        public string Himmei
        {
            get { return _himmei; }
            set
            {
                this.SetProperty(ref this._himmei, value);
            }
        }
        private List<DantaiDataModel> _dantaiList;
        public List<DantaiDataModel> DantaiList
        {
           get { return this._dantaiList; }
           set
            {
               this.SetProperty(ref this._dantaiList, value);
            }
        }
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
        private string _dantaiName;
        public string DantaiName
        {
            get { return this._dantaiName; }
            set
            {
               this.SetProperty(ref this._dantaiName, value);
            }
        }
        private string _koushinshaCode;
        public string KoushinshaCode
        {
            get { return this._koushinshaCode; }
            set
            {
                this.SetProperty(ref this._koushinshaCode, value);
            }
        }
        private string _koushinshaName;
        public string KoushinshaName
        {
            get { return this._koushinshaName; }
            set
            {
                this.SetProperty(ref this._koushinshaName, value);
            }
        }
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

                    this.SetProperty(ref this._koushinDateStart, null);
            }
        }
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

                this.SetProperty(ref this._koushinDateEnd, null);
            }
        }
        private bool _isStop = true;
        public bool IsStop
        {
            get { return this._isStop; }
            set
            {
                this.SetProperty(ref this._isStop, value);
            }
        }
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set
            {
                if(value == null)
                {
                    this.IsError = false;
                }
                else
                {
                    this.IsError = true;
                }
                this.SetProperty(ref this._errorMessage, value);
            }
        }
        public bool IsError { get; private set; } = false;
        #endregion

        #region コンストラクタ
        public AN82070Model()
        {

        }
        #endregion

        #region メソッド
        /// <summary>
        ///  団体一覧を取得
        /// </summary>
        /// <returns>団体一覧</returns>
        public void SearchDantaiIchiran()
        {
            var result = new List<DantaiDataModel>()
            {
               new DantaiDataModel()
               {
                   StopKubun = '0',
                   HimmeiCode ="1000",
                   Himmei = "肉豚",
                   DantaiCode="101",
                   DantaiName="肉豚出荷組合",
                   KoushinshaName="電算　豚郎",
                   KoushinDateTime= DateTime.Now
               },
               new DantaiDataModel()
               {
                   StopKubun = '0',
                   HimmeiCode ="2100",
                   Himmei = "子豚",
                   DantaiCode="201",
                   DantaiName="子豚出荷組合",
                   KoushinshaName="電算　子豚郎",
                   KoushinDateTime= DateTime.Now
               },
               new DantaiDataModel()
               {
                   StopKubun = '1',
                   HimmeiCode ="3000",
                   Himmei = "牛",
                   DantaiCode="300",
                   DantaiName="牛出荷組合",
                   KoushinshaName="電算　牛郎",
                   KoushinDateTime= DateTime.Now
               }
            };

           this.DantaiList = result;
        }

        /// <summary>
        /// 検索条件の入力状態を返却
        /// </summary>
        /// <returns></returns>
        public bool ExistSearchConditions()
        {
            if (this.HimmeiCodeStart != null) { return true; }
            if (this.HimmeiCodeEnd != null) { return true; }
            if (this.DantaiCodeStart != null) { return true; }
            if (this.DantaiCodeEnd != null) { return true; }
            if (this.DantaiName != null) { return true; }
            if (this.KoushinshaCode != null) { return true; }
            if (this.KoushinshaName != null) { return true; }
            if (this.KoushinDateStart != null) { return true; }
            if (this.KoushinDateEnd != null) { return true; }
            this.ErrorMessage = "検索条件を入力してください";
            return false;
        }

        /// <summary>
        /// エラーメッセージのクリア
        /// </summary>
        public void ClearErrorMessage()
        {
            this.ErrorMessage = string.Empty;
        }

        /// <summary>
        /// モデル値を初期化
        /// </summary>
        public void InitializeModelItem()
        {
            this.HimmeiCodeStart = null;
            this.HimmeiCodeEnd = null;
            this.Himmei = null;
            this.DantaiCodeStart = null;
            this.DantaiCodeEnd = null;
            this.DantaiName = null;
            this.KoushinshaCode = null;
            this.KoushinshaName = null;
            this.KoushinDateStart = null;
            this.KoushinDateEnd = null;
            this.IsStop = true;
            this.DantaiList = new List<DantaiDataModel>();
            this.ErrorMessage = null;
        }

        #endregion

    }
}
