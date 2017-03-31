﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ViewModels;

namespace WPFMVVMEFPrototype.ServiceLocator
{
    public interface INavigationService
    {
        void Shell(ViewModel viewModel);
        void Setting(ViewModel viewModel);
    }
}
