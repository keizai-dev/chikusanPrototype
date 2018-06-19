using JaGunma.Chikusan.DataModels;
using JaGunma.Chikusan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.RetentionData
{
    public static class AN22021RetentionData
    {
        #region メンバ変数
        public static string Himmei { get; set; }
        public static string HimmeiCode { get; set; }
        public static string DantaiCode { get; set; }
        public static string DantaiName { get; set; }
        public static string KoushinshaCode { get; set; }
        public static string KoushinshaName { get; set; }
        public static string KoushinDate { get; set; }
        public static bool IsStop { get; set; }
        #endregion

        /// <summary>
        /// 保持する値をセット
        /// </summary>
        /// <param name="model"></param>
        public static void SetValues(AN22021Model model)
        {
            DantaiCode = model.DantaiCode;
            DantaiName = model.DantaiName;
            HimmeiCode = model.HimmeiCode;
            Himmei = model.Himmei;
            KoushinshaCode = model.KoushinshaCode;
            KoushinshaName = model.KoushinshaName;
            KoushinDate = model.KoushinDate;
            IsStop = model.IsStop;
        }


    }
}
