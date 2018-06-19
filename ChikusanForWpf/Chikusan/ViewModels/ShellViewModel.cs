using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.Chikusan.ViewModels
{
        public class ShellViewModel
        {
            public ShellViewModel(IRegionManager rm)
            {
                rm.RequestNavigate("MainRegion", "AN22020View");
                rm.RequestNavigate("HeaderRegion", "HeaderView");
        }
        }
}
