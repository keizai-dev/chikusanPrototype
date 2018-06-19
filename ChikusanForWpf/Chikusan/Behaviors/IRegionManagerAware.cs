using Prism.Regions;

namespace JaGunma.Chikusan.Behavior
{
    public interface IRegionManagerAware
    {
        IRegionManager RegionManager { get; set; }
    }
}
