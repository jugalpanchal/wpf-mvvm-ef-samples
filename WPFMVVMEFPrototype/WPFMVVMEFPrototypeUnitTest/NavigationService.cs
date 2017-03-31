using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ServiceLocator;
using WPFMVVMEFPrototype.ViewModels;

namespace WPFMVVMEFPrototypeUnitTest
{
    public class NavigationServiceMock : INavigationService
    {
        public bool ShellActive { get; private set; }
        public ShellViewModel ShellVM { get; private set; }

        public bool SettingActive { get; private set; }

        public void Shell(ViewModel viewModel)
        {
            this.ShellActive = true;
            this.ShellVM = viewModel as ShellViewModel;
        }

        public void Setting(ViewModel viewModel)
        {
            this.SettingActive = true;
        }
    }
}