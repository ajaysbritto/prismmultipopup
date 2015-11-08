using Infrastructure;
using Prism.Commands;
using Prism.Regions;
using System;
using System.ComponentModel.Composition;

namespace PopupModule
{
    [Export]
    public class PopupViewModel
    {
        private readonly MyCommandProxy commandProxy;
        DelegateCommand<string> showOrderDetailsCommand { get; set; }
        private IRegionManager _regionManager;

        [ImportingConstructor]
        public PopupViewModel(IRegionManager regionManager, MyCommandProxy commandProxy)
        {
            showOrderDetailsCommand = new DelegateCommand<string>(ShowOrderDetailsView, SubmitAllCanExecute);
            showOrderDetailsCommand.IsActive = true;
            this.commandProxy = commandProxy;
            commandProxy.ShowOrderCommand.RegisterCommand(showOrderDetailsCommand);
            _regionManager = regionManager;
        }

        protected bool SubmitAllCanExecute(string id)
        {
            return true;
        }

        private void ShowOrderDetailsView(string id)
        {
            _regionManager.RequestNavigate(RegionNames.PopupRegion, new Uri("PopupControl", UriKind.Relative));
        }

        }
    }
