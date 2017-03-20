using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.Commands;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    class LoginViewModel : ViewModel
    {
        #region Properties

        public string UserId { get; set; }

        #endregion

        #region Command Properties

        public IRelayCommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.LoginCommand = new RelayCommand(Authentication, p => true);
        }

        #endregion

        #region Command Methods

        private void Authentication(object password)
        {
            SecureString SecurePassword = password as SecureString;
            this.NavigationService.Shell(new ShellViewModel(this.NavigationService));
        }

        #endregion
    }
}
