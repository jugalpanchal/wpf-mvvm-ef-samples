using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using WPFMVVMEFPrototype.ServiceLocator;
using WPFMVVMEFPrototype.ViewModels;
using WPFMVVMEFPrototype.Views;

namespace WPFMVVMEFPrototype
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Privte Fields
        
        private readonly WindowState windowState = WindowState.Normal;
        private readonly WindowStartupLocation windowStartupLocation = WindowStartupLocation.CenterScreen;

        #endregion

        #region Overide Methods

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var loginView = new LoginView()
            {
                WindowState = windowState,
                WindowStartupLocation = windowStartupLocation
            };

            var navigationService = new NavigationService(windowState, windowStartupLocation, loginView);

            var loginViewModel = new LoginViewModel(navigationService);
            loginView.DataContext = loginViewModel;
            loginView.Show();
        }

        #endregion
    }
}
