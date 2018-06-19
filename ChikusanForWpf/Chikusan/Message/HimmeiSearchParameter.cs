using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Message
{
    /// <summary>
    /// 品名検索パラメータクラス
    /// </summary>
    public class HimmeiSearchParameter
    {
        public string HimmeiCode { get; set; }
        public string HimmeiCodeStart { get; set; }
        public string HimmeiCodeEnd { get; set; }
        public string Himmei { get; set; }
    
    }
}
