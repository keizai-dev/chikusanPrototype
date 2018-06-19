using JaGunma.HeaderModule;
using JaGunma.Shell;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Jagunma.Shell
{
    class Bootstrapper : UnityBootstrapper
    {
        ///// <summary>
        ///// Shellを作成する
        ///// </summary>
        ///// <returns></returns>
        //protected override DependencyObject CreateShell()
        //{
        //    // this.ContainerでUnityのコンテナ取得
        //    return this.Container.TryResolve<JaGunma.Shell.Views.Shell>();
        //}

        /// <summary>
        /// Shellを表示する
        /// </summary>
        protected override void InitializeShell()
        {
            ((Window)this.Shell).Show();
        }

        ///// <summary>
        ///// Module構成
        ///// </summary>
        //protected override void ConfigureModuleCatalog()
        //{
        //    base.ConfigureModuleCatalog();

        //    var catalog = (ModuleCatalog)this.ModuleCatalog;
        //    catalog.AddModule(typeof(Shell));
        //    catalog.AddModule(typeof(HeaderModule));
        //}
    }
}
