using Prism.Mef;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace Prism_Multi
{
    class MyBootStrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MyBootStrapper).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Infrastructure.AutoPopulateExportedViewsBehavior).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(PopupModule.PopupModule).Assembly));
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (AppShell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            var factory = base.ConfigureDefaultRegionBehaviors();
            factory.AddIfMissing("AutoPopulateExportedViewsBehavior", typeof(Infrastructure.AutoPopulateExportedViewsBehavior));
            return factory;
        }

        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<AppShell>();
        }
    }
}
