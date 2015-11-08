using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class WindowDialogActivationBehavior : DialogActivationBehavior
    {
        /// <summary>
        /// Creates a wrapper for the WPF <see cref="System.Windows.Window"/>.
        /// </summary>
        /// <returns>Instance of the <see cref="System.Windows.Window"/> wrapper.</returns>
        protected override IWindow CreateWindow()
        {
            return new WindowWrapper();
        }
    }
}
