using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ViewModels;
using WPFMVVMEFPrototype.Views;

namespace WPFMVVMEFPrototype.ServiceLocator
{
    class NavigationService : INavigationService
    {
        public void Home(ViewModel viewModel)
        {
            var homeView = new HomeView()
            {
                DataContext = viewModel
            };
            homeView.Show();
        }
    }
}
