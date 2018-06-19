using JaGunma.Chikusan.RetentionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.DataModels
{
    public class ShikiriDto: IDisposable
    {
        #region メンバ変数
        public string ShoriDate { get; set; }
        public string ShikiriNo { get; set; }
        public string HimmeiCode { get; set; }
        public string Himmei { get; set; }
        public string ShishoCode { get; set; }
        public string ShishoName { get; set; }
        public string ShukkashaCode { get; set; }
        public string ShukkashaName { get; set; }
        public string UnsougyoushaCode { get; set; }
        public string UnsougyoushaName { get; set; }
        public string ShukkasakiCode { get; set; }
        public string ShukkasakiName { get; set; }
        public string ShukkaDate { get; set; }
        public string ErrorItem { get; set; }
        public bool IsSelected { get; set; } = false;

        public static List<ShikiriDto> ShikiriTestData { get; set; }
        #endregion


        #region コンストラクタ
        public ShikiriDto()
        {
        }
        #endregion

        #region メソッド
        public static List<ShikiriDto> GetTestData()
        {
            if(AN13020RetentionData.ShikiriDataList.Count > 0)
            {
                return AN13020RetentionData.ShikiriDataList;
            }
            AN13020RetentionData.ShikiriDataList =  new List<ShikiriDto>()
            {
               new ShikiriDto()
               {
                ShoriDate = DateTime.Now.ToShortDateString(),
                ShukkaDate = DateTime.Now.ToShortDateString(),
                ShikiriNo = "0001",
                HimmeiCode = "1000",
                Himmei = "肉豚",
                ShishoCode = "001",
                ShishoName = "本所",
                ShukkashaCode = "2601041",
                ShukkashaName = "豚　史郎",
                UnsougyoushaCode = "001",
                UnsougyoushaName = "くみあい運輸",
                ShukkasakiCode = "600010",
                ShukkasakiName = "食肉卸売市場",
                ErrorItem = "出荷者エラー（年齢と性別と住所となにかが取得できません）"
               },
                 new ShikiriDto()  
               {
                ShoriDate = DateTime.Now.ToShortDateString(),
                ShukkaDate = DateTime.Now.ToShortDateString(),
                ShikiriNo = "0002",
                HimmeiCode = "3000",
                Himmei = "牛",
                ShishoCode = "001",
                ShishoName = "本所",
                ShukkashaCode = "2601061",
                ShukkashaName = "牛　太郎",
                UnsougyoushaCode = "001",
                UnsougyoushaName = "くみあい運輸",
                ShukkasakiCode = "600010",
                ShukkasakiName = "食肉卸売市場",
                ErrorItem = "出荷者エラー（年齢と性別と住所となにかが取得できません）"
               },
                 new ShikiriDto()
               {
                ShoriDate = DateTime.Now.ToShortDateString(),
                ShukkaDate = DateTime.Now.ToShortDateString(),
                ShikiriNo = "0003",
                HimmeiCode = "1000",
                Himmei = "肉豚",
                ShishoCode = "001",
                ShishoName = "本所",
                ShukkashaCode = "5521001",
                ShukkashaName = "山崎　パン多",
                UnsougyoushaCode = "001",
                UnsougyoushaName = "くみあい運輸",
                ShukkasakiCode = "600010",
                ShukkasakiName = "食肉卸売市場",
                ErrorItem = "不明なエラー（めっちゃ長いエラー文、新元号の発表は、2019年5月1日の改元の半年前と言われていた時期もあったが、新聞報道によると、政府会合では改元1カ月前に発表する方針で固まったようだ。 改元に関して合わせて話題に上るのが、情報システムの改修だ。民間企業の日常業務では西暦を使うことが多いが、官公庁、金融機関、公的機関に提出する文書等では、まだまだ和暦が使われており、日々の業務で使われているシステムが新..."
               }
            };
            return AN13020RetentionData.ShikiriDataList;
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
