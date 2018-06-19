using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.Message
{
    public class HimmeiSearchResult
    {
        public long HimmeiID { get; set; }
        public string HimmeiCode {get;set;}
        public string Himmei { get; set; }

        public HimmeiSearchResult()
        {

        }

        public HimmeiSearchResult(string himmeiCode, string himmei)
        {
            this.HimmeiCode = himmeiCode;
            this.Himmei = himmei;
        }


    }
}
