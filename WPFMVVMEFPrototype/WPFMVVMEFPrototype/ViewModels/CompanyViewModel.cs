﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    class CompanyViewModel : ViewModel
    {
        public CompanyViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
