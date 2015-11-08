using Infrastructure;
using System.Windows.Controls;

namespace PopupModule.Views
{
    /// <summary>
    /// Interaction logic for PopupControl.xaml
    /// </summary>
    [ViewExport(RegionName = RegionNames.PopupRegion)]
    public partial class PopupControl : UserControl
    {
        public PopupControl()
        {
            InitializeComponent();
        }
    }
}
