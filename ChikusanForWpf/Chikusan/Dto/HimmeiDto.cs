using JaGunma.Chikusan.RetentionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.DataModels
{
    public class HimmeiDto: IDisposable
    {
        #region メンバ変数
        public string HimmeiCode { get; set; }
        public string Himmei { get; set; }
        public string KoushinshaCode { get; set; }
        public string KoushinshaName { get; set; }
        public DateTime KoushinDateTime { get; set; }
        public bool IsSelected { get; set; } = false;

        public static List<HimmeiDto> HimmeiTestData { get; set; }
        #endregion


        #region コンストラクタ
        public HimmeiDto()
        {
        }
        #endregion

        #region メソッド
        public static List<HimmeiDto> GetTestData()
        {

            return new List<HimmeiDto>()
            {
               new HimmeiDto()
               {
                   HimmeiCode = "1000",
                   Himmei = "肉豚",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "2200",
                   Himmei = "種豚",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "3000",
                   Himmei = "牛",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "3100",
                   Himmei = "肉専用牛",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "3102",
                   Himmei = " 肉専用牛メス・屠体",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "3103",
                   Himmei = " 肉専用牛ヌキ・屠体",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "3300",
                   Himmei = " 乳用牛",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "3306",
                   Himmei = " 乳用牛 メス・主体",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               },
                new HimmeiDto()
               {
                   HimmeiCode = "3400",
                   Himmei = "スモール",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               }
                ,
                new HimmeiDto()
               {
                   HimmeiCode = "子牛006",
                   Himmei = "子牛",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               } ,
                new HimmeiDto()
               {
                   HimmeiCode = "3600",
                   Himmei = " 乳用子牛",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               } ,
                new HimmeiDto()
               {
                   HimmeiCode = "5000",
                   Himmei = " 牛乳",
                   KoushinshaCode = "AN001002",
                   KoushinshaName = "電算　豚郎",
                   KoushinDateTime = DateTime.Now
               }
            };
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
