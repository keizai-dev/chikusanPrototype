using JaGunma.Chikusan.DataModels;
using JaGunma.Chikusan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.RetentionData
{
    public static class HeaderRetentionData
    {
        #region メンバ変数
        public static string JaID { get; set; }
        public static string TempoID { get; set; }
        public static string JaCode { get; set; }
        public static string TempoCode { get; set; }
        public static string JaName { get; set; }
        public static string TempoName { get; set; }
        public static string UserID { get; set; }
        public static string UserName { get; set; }
        #endregion

        static HeaderRetentionData()
        {
        }

    }
}
