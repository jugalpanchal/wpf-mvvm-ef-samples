using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.Commands;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    class HomeViewModel : ViewModel
    {        
        #region Command Properties

        public IRelayCommand NewCommand { get; set; }
        public IRelayCommand OpenCommand { get; set; }
        public IRelayCommand SaveCommand { get; set; }
        public IRelayCommand ExitCommand { get; set; }
        public IRelayCommand SettingCommand { get; set; }
        public IRelayCommand HelpCommand { get; set; }
        #endregion
        #region Constructor

        public HomeViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.NewCommand = new RelayCommand(New, p => this.CanNew());
            this.OpenCommand = new RelayCommand(Open, p => this.CanOpen());
            this.SaveCommand = new RelayCommand(Save, p => this.CanSave());
            this.ExitCommand = new RelayCommand(Exit, p => this.CanExit());
            this.SettingCommand = new RelayCommand(Setting, p => this.CanSetting());
            this.HelpCommand = new RelayCommand(Help, p => this.CanHelp());
        }

        #endregion

        #region Command Methods

        private void New(object obj)
        {
            
        }

        private bool CanNew()
        {
            return true;
        }

        private void Open(object obj)
        {
            
        }

        private bool CanOpen()
        {
            return true;
        }

        private void Save(object obj)
        {
            
        }

        private bool CanSave()
        {
            return true;
        }

        private void Exit(object obj)
        {
            
        }

        private bool CanExit()
        {
            return true;
        }

        private void Setting(object obj)
        {
            
        }

        private bool CanSetting()
        {
            return true;
        }

        private void Help(object obj)
        {
            
        }

        private bool CanHelp()
        {
            return true;
        }

        #endregion
    }
}