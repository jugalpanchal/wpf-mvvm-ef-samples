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
            loginViewModel.UserId = "Jugal";
            
            //Hardcoded password for debug mode.
            SecureString secureString = new SecureString();
            secureString.AppendChar('j');
            secureString.AppendChar('u');
            secureString.AppendChar('g');
            secureString.AppendChar('a');
            secureString.AppendChar('l');

            loginViewModel.LoginCommand.Execute(secureString);
#else
            loginView.Show();
#endif
        }

        #endregion
    }
}
