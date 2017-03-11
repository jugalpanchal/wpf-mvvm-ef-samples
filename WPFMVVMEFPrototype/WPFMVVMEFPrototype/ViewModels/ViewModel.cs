using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    abstract class ViewModel : INotifyPropertyChanged
    {
        #region Protected Fields

        protected NavigationService NavigationService { get; private set; }

        #endregion

        #region Public Fields
        
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Contructor

        public ViewModel(NavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        #endregion

        #region Protected Method

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}