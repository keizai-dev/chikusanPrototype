using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Message
{
    /// <summary>
    /// ファイルオープンパラメータクラス
    /// </summary>
    public class FileOpenParameter
    {
        public string Title { get; set; } = "ファイルを開く";
        public string Filter { get; set; } = "CSVファイル|*.csv";
        public string InitialDirectory { get; set; } = @"C:\Users";

    }
}
