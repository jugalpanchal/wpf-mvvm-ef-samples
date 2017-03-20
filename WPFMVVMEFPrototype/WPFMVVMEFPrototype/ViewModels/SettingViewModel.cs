using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    class SettingViewModel : ViewModel
    {
        #region Constructor

        public SettingViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        #endregion
    }
}
