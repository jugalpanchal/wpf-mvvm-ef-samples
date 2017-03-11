using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMEFPrototype.Models
{
    class Company : Model
    {
        #region Properties

        public string Name { get; set; }
        public ObservableCollection<Variant> Variants { get; set; }

        #endregion

        #region Constructor

        public Company(string name)
        {
            this.Variants = new ObservableCollection<Variant>();
            this.Name = name;
        }

        #endregion

        #region Private Methods

        private void AddVariant(Variant variant)
        {
            this.Variants.Add(variant);
        }

        #endregion
    }
}
