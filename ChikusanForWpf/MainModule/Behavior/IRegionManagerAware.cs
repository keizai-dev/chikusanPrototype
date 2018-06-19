using Prism.Regions;

namespace JaGunma.MainModule.Behavior
{
    public interface IRegionManagerAware
    {
        IRegionManager RegionManager { get; set; }
    }
}
