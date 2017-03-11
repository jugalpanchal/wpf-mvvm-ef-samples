using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMEFPrototype.Models
{
    class Model : INotifyPropertyChanged
    {
        #region Public Event
        
        public event PropertyChangedEventHandler PropertyChanged;

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
