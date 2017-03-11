using System;
using System.Collections.Generic;
using System.Linq;
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

        public string Password { get; set; }

        #endregion

        #region Command Properties

        public IRelayCommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel(NavigationService navigationService)
            : base(navigationService)
        {
            this.LoginCommand = new RelayCommand(p => authentication(), p =>true);
        }

        #endregion

        #region Command Methods

        private void authentication()
        {

        }

        #endregion
    }
}
