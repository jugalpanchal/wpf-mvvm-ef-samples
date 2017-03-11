using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMEFPrototype.Commands
{
    class RelayCommand : IRelayCommand
    {
        #region Private Function Pointer

        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        #endregion

        #region public Event

        public event EventHandler CanExecuteChanged;

        #endregion

        #region Constructor

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion

        #region Public Methods

        public bool CanExecute(object parameter)
        {
            return this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        public void NotifyCanExecuteChanged(EventArgs e)
        {
            if (this.CanExecuteChanged != null)
                this.CanExecuteChanged(this, e);
        }

        #endregion
    }
}
