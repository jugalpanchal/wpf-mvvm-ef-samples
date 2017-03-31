using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFMVVMEFPrototype.ServiceLocator;
using WPFMVVMEFPrototype.ViewModels;
using System.Security;

namespace WPFMVVMEFPrototypeUnitTest
{
    [TestClass]
    public class NavigationServiceUnitTest
    {
        [TestMethod]
        public void ShellTest()
        {
            NavigationServiceMock navigationService = new NavigationServiceMock();
            var loginViewModel = new LoginViewModel(navigationService);

            loginViewModel.UserId = "Jugal";

            SecureString secureString = new SecureString();
            secureString.AppendChar('l');
            secureString.AppendChar('a');
            secureString.AppendChar('g');
            secureString.AppendChar('u');
            secureString.AppendChar('j');

            loginViewModel.LoginCommand.Execute(secureString);

            Assert.IsTrue(navigationService.ShellActive, "Shell is not active.");
        }

        [TestMethod]
        public void SettingTest()
        {
            NavigationServiceMock navigationService = new NavigationServiceMock();
            var loginViewModel = new LoginViewModel(navigationService);

            loginViewModel.UserId = "Jugal";

            SecureString secureString = new SecureString();
            secureString.AppendChar('l');
            secureString.AppendChar('a');
            secureString.AppendChar('g');
            secureString.AppendChar('u');
            secureString.AppendChar('j');

            loginViewModel.LoginCommand.Execute(secureString);
            Assert.IsTrue(navigationService.ShellActive, "Shell is not active.");

            navigationService.ShellVM.SettingCommand.Execute(null);
            Assert.IsTrue(navigationService.SettingActive, "Setting is not active.");
        }
    }
}