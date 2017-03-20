using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFMVVMEFPrototype.ViewModels;
using WPFMVVMEFPrototype.Views;

namespace WPFMVVMEFPrototype.ServiceLocator
{
    class NavigationService : INavigationService
    {
        #region private Fields

        private readonly WindowState windowState;
        private readonly WindowStartupLocation windowStartupLocation;
        private readonly Window loginView;
        
        #endregion

        #region Constructor

        public NavigationService(Window loginView)
        {
            this.loginView = loginView;
        }

        public NavigationService(WindowState windowState, WindowStartupLocation windowStartupLocation, LoginView loginView)
        {
            this.windowState = windowState;
            this.windowStartupLocation = windowStartupLocation;
            this.loginView = loginView;
        }

        #endregion

        #region Public Methods

        public void Shell(ViewModel viewModel)
        {
            var shellView = new ShellView()
            {
                WindowState = this.windowState,
                WindowStartupLocation = this.windowStartupLocation,
                DataContext = viewModel
            };
            this.loginView.Close();
            shellView.Show();
        }

        #endregion
    }
}
