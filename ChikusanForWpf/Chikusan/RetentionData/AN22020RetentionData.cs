using JaGunma.Chikusan.DataModels;
using JaGunma.Chikusan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.RetentionData
{
    public static class AN22020RetentionData
    {
        #region メンバ変数
        public static List<DantaiDto> DantaiDataList { get; set; } 
        public static DantaiDto SelectedDantai { get; set; }
        public static string HimmeiCodeStart { get; set; }
        public static string HimmeiCodeEnd { get; set; }
        public static string Himmei { get; set; }
        public static string DantaiCodeStart { get; set; }
        public static string DantaiCodeEnd { get; set; }
        public static string DantaiName { get; set; }
        public static string KoushinshaCode { get; set; }
        public static string KoushinshaName { get; set; }
        public static string KoushinDateStart { get; set; }
        public static string KoushinDateEnd { get; set; }
        #endregion

        static AN22020RetentionData()
        {
            DantaiDataList = new List<DantaiDto>();
            SelectedDantai = new DantaiDto();
        }

        public static void SetValues(AN22020Model model)
        {
            DantaiCodeStart = model.DantaiCodeStart;
            DantaiCodeEnd = model.DantaiCodeEnd;
            DantaiName = model.DantaiName;
            HimmeiCodeStart = model.HimmeiCodeStart;
            HimmeiCodeEnd = model.HimmeiCodeEnd;
            Himmei = model.Himmei;
            KoushinshaCode = model.KoushinshaCode;
            KoushinshaName = model.KoushinshaName;
            KoushinDateStart = model.KoushinDateStart;
            KoushinDateEnd = model.KoushinDateEnd;
            //var dantaiList = model.DantaiList.Select(x => x).ToList();
            SelectedDantai = model.SelectedDantai;
            DantaiDataList = model.DantaiList.ToList();
        }

    }
}
