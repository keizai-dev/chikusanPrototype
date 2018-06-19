using JaGunma.HeaderModule.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaGunma.HeaderModule
{
    public class HeaderModule:IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            this.Container.RegisterType<object, HeaderView>(nameof(HeaderView));

            // register views @ region
            this.RegionManager.RegisterViewWithRegion("HeaderRegion", typeof(HeaderView));
        }
        public HeaderModule(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;
        }

    }
}
