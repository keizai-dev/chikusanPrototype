using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.MainModule.DataModels
{
    public class DantaiDataModel : IDisposable
    {
        #region メンバ変数
        private char _stopKubun;
        public char StopKubun {
            get { return this._stopKubun; }
            set
            {
               this._stopKubun = value == '1' ? '○' : ' ';
            }
        }
        public string HimmeiCode { get; set; }
        public string Himmei { get; set; }
        public string DantaiCode { get; set; }
        public string DantaiName { get; set; }
        public string KoushinshaName { get; set; }
        public DateTime KoushinDateTime { get; set; }
        #endregion


        #region コンストラクタ
        #endregion

        #region メソッド
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
        // ~AN82070DataModel() {
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
