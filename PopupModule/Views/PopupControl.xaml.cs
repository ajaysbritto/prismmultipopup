using Infrastructure;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PopupModule.Views
{
    /// <summary>
    /// Interaction logic for PopupControl.xaml
    /// </summary>
    [Export("PopupControl")]
    [ViewExport(RegionName = RegionNames.DummyRegion)]
    public partial class PopupControl : UserControl
    {
        public PopupControl()
        {
            InitializeComponent();
        }

        [Import]
        public PopupViewModel ViewModel
        {
            set
            {
                DataContext = value;
            }
        }
    }
}
