using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMEFPrototype.Commands;
using WPFMVVMEFPrototype.DataModel;
using WPFMVVMEFPrototype.Models;
using WPFMVVMEFPrototype.ServiceLocator;

namespace WPFMVVMEFPrototype.ViewModels
{
    class ShellViewModel : ViewModel
    {
        #region Properties

        public ObservableCollection<CompanyModel> Companies { get; set; }

        #endregion

        #region Command Properties

        public IRelayCommand NewCommand { get; set; }
        public IRelayCommand OpenCommand { get; set; }
        public IRelayCommand SaveCommand { get; set; }
        public IRelayCommand ExitCommand { get; set; }
        public IRelayCommand SettingCommand { get; set; }
        public IRelayCommand HelpCommand { get; set; }
        #endregion

        #region Constructor

        public ShellViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.NewCommand = new RelayCommand(New, p => this.CanNew());
            this.OpenCommand = new RelayCommand(Open, p => this.CanOpen());
            this.SaveCommand = new RelayCommand(Save, p => this.CanSave());
            this.ExitCommand = new RelayCommand(Exit, p => this.CanExit());
            this.SettingCommand = new RelayCommand(Setting, p => this.CanSetting());
            this.HelpCommand = new RelayCommand(Help, p => this.CanHelp());

            this.DataInitialization();
        }
        
        #endregion

        #region Private Method

        private void DataInitialization()
        {
            this.Companies = new ObservableCollection<CompanyModel>();

            using(var context = new MotorDBEntities())
            {
                foreach(var company in context.Companies)
                {
                    var companyModel = new CompanyModel(company.Name);
                    this.Companies.Add(companyModel);
                }
            }
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
            this.NavigationService.Setting(new SettingViewModel(this.NavigationService));
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