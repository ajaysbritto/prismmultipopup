using System.Windows;

namespace Prism_Multi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MyBootStrapper bootstrapper = new MyBootStrapper();
            bootstrapper.Run();
        }
    }
}
