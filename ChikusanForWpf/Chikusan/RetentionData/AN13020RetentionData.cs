using JaGunma.Chikusan.DataModels;
using JaGunma.Chikusan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.RetentionData
{
    public static class AN13020RetentionData
    {
        #region メンバ変数
        public static List<ShikiriDto> ShikiriDataList { get; set; } 
        public static ShikiriDto SelectedShikiri { get; set; }
        #endregion

        static AN13020RetentionData()
        {
            ShikiriDataList = new List<ShikiriDto>();
            SelectedShikiri = new ShikiriDto();
        }

        public static void SetValues(ShikiriModel model)
        {

        }

    }
}
