using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    class HomeViewModel : ViewModel
    {
        #region Constructor

        public HomeViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        #endregion
    }
}
