using JaGunma.Shell.Commons;
using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Shell.Message
{
    public class NotificationCustom:Notification
    {

        public DisplayMode DisplayMode { get; set; }

        public NotificationCustom():base()
        {

        }

    }
}
