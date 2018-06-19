﻿using Prism.Common;
using Prism.Regions;
using System;
using System.Collections.Specialized;

namespace JaGunma.Chikusan.Behavior
{
    public class RegionManagerAwareBehavior : RegionBehavior
    {
        public static string Key { get; } = nameof(RegionManagerAwareBehavior);

        protected override void OnAttach()
        {
            this.Region.ActiveViews.CollectionChanged += this.ActiveViews_CollectionChanged;
        }

        private void ActiveViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Action<IRegionManagerAware> setRegionManager = x => x.RegionManager = this.Region.RegionManager;
                    MvvmHelpers.ViewAndViewModelAction(e.NewItems[0], setRegionManager);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Action<IRegionManagerAware> resetRegionManager = x => x.RegionManager = null;
                    MvvmHelpers.ViewAndViewModelAction(e.OldItems[0], resetRegionManager);
                    break;
            }
        }
    }
}
