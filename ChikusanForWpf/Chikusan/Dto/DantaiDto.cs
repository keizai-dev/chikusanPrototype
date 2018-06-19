using JaGunma.Chikusan.RetentionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.DataModels
{
    public class DantaiDto: IDisposable
    {
        #region メンバ変数
        private char _stopKubun;
        public char StopKubun {
            get { return this._stopKubun; }
            set
            {
                //this.StopText = value == '1' ? '○' : ' ';
                this._stopKubun = value;
            }
        }
        //public char StopText { get; set; }
        public string HimmeiCode { get; set; }
        public string Himmei { get; set; }
        public string DantaiCode { get; set; }
        public string DantaiName { get; set; }
        public string KoushinshaCode { get; set; }
        public string KoushinshaName { get; set; }
        public DateTime KoushinDateTime { get; set; }
        public bool IsSelected { get; set; } = false;

        public static List<DantaiDto> DantaiTestData { get; set; }
        #endregion


        #region コンストラクタ
        public DantaiDto()
        {
        }
        #endregion

        #region メソッド
        public static List<DantaiDto> GetTestData()
        {
            if(AN22020RetentionData.DantaiDataList.Count > 0)
            {
                return AN22020RetentionData.DantaiDataList;
            }
            AN22020RetentionData.DantaiDataList =  new List<DantaiDto>()
            {
               new DantaiDto()
               {
                StopKubun = '0',
                   HimmeiCode = "1000",
                   Himmei = "肉豚",
                   DantaiCode = "101",
                   DantaiName = "肉豚出荷組合",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
               new DantaiDto()
               {
                   StopKubun = '0',
                   HimmeiCode = "2100",
                   Himmei = "子豚",
                   DantaiCode = "201",
                   DantaiName = "子豚出荷組合",
                   KoushinshaCode = "AN001003",
                   KoushinshaName = "電算　子豚郎",
                   KoushinDateTime = DateTime.Now
               },
               new DantaiDto()
               {
                   StopKubun = '1',
                   HimmeiCode = "3000",
                   Himmei = "牛",
                   DantaiCode = "300",
                   DantaiName = "牛出荷組合",
                   KoushinshaCode = "AN001004",
                   KoushinshaName = "電算　牛郎",
                   KoushinDateTime = DateTime.Now
               },
               new DantaiDto()
               {
                   StopKubun = '1',
                   HimmeiCode = "3400",
                   Himmei = "子牛",
                   DantaiCode = "340",
                   DantaiName = "子牛出荷組合",
                   KoushinshaCode = "AN001005",
                   KoushinshaName = "甲　士郎",
                   KoushinDateTime = DateTime.Now
               }
            };

            //参照先がすべて同じなので注意
            var bigdata = Enumerable.Repeat(
                               new DantaiDto()
                               {
                                   StopKubun = '0',
                                   HimmeiCode = "3400",
                                   Himmei = "子牛",
                                   DantaiCode = "340",
                                   DantaiName = "子牛出荷組合",
                                   KoushinshaCode = "AN001005",
                                   KoushinshaName = "沢山　出太郎",
                                   KoushinDateTime = DateTime.Now
                               }
                               , 10000
                ).ToList();
            AN22020RetentionData.DantaiDataList.AddRange(bigdata as List<DantaiDto>);

            return AN22020RetentionData.DantaiDataList;
        }

        /// <summary>
        /// 停止区分を変換して返却します
        /// </summary>
        /// <param name="kubun"></param>
        /// <returns></returns>
        public static bool StopKubunToBool(char kubun)
        {
            if (kubun == '1') return true;
            if (kubun == '0') return false;
            return false;
        }

        #endregion


        #region IDisposable Support
        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。

                disposedValue = true;
            }
        }

        // TODO: 上の Dispose(bool disposing) にアンマネージ リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします。
        // ~AN22020DataModel() {
        //   // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
        //   Dispose(false);
        // }

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        void IDisposable.Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // TODO: 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
