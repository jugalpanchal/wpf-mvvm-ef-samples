﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    public class CompanyViewModel : ViewModel
    {
        #region Constructor

        public CompanyViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        #endregion
    }
}
