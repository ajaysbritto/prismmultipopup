using Prism.Mef;
using System.Windows;

namespace Prism_Multi
{
    class MyBootStrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
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
