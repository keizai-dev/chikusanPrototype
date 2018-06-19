using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Message
{
    /// <summary>
    /// ファイル保存パラメータクラス
    /// </summary>
    public class FileSaveParameter
    {
        public string Title { get; set; } = "ファイルを保存";
        public string Filter { get; set; } = "CSVファイル|*.csv";
        public string FileName { get; set; } = "超機密情報ファイル";
        public string InitialDirectory { get; set; } = @"C:\Users";

    }
}
