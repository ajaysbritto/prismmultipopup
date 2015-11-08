using Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prism_Multi
{
    /// <summary>
    /// Interaction logic for AppShell.xaml
    /// </summary>
    [Export(typeof(AppShell))]
    public partial class AppShell : Window
    {
        private readonly MyCommandProxy commandProxy;

        [ImportingConstructor]
        public AppShell(MyCommandProxy commandProxy)
        {
            InitializeComponent();
            this.commandProxy = commandProxy;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            commandProxy.ShowOrderCommand.Execute("0");
        }
    }
}
