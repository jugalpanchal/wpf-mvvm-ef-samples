﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    public class CarViewModel : ViewModel
    {
        #region Constructor

        public CarViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        #endregion
    }
}
