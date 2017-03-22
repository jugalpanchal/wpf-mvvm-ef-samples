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
        
        private readonly WindowState windowState = WindowState.Maximized;
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

#if DEBUG
            //Hardcoded User id and password for debug mode.

            loginViewModel.UserId = "Jugal";

            SecureString secureString = new SecureString();
            secureString.AppendChar('l');
            secureString.AppendChar('a');
            secureString.AppendChar('g');
            secureString.AppendChar('u');
            secureString.AppendChar('j');

            loginViewModel.LoginCommand.Execute(secureString);
#else
            loginView.Show();
#endif
        }

        #endregion
    }
}
