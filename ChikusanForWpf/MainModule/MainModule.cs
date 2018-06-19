using JaGunma.MainModule.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JaGunma.MainModule
{
    public class MainModule:IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            // Git Test Tajima3
            this.Container.RegisterType<object, AN82070View>(nameof(AN82070View));

            // register views @ region
            this.RegionManager.RegisterViewWithRegion("MainRegion", typeof(AN82070View));

        }

        public MainModule(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
        }

    }
}
