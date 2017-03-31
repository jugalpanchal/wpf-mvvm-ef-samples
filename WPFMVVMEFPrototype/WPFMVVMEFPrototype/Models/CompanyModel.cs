using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMEFPrototype.Models
{
    public class CompanyModel : Model
    {
        #region Properties

        public string Name { get; set; }
        public ObservableCollection<VariantModel> Variants { get; set; }

        #endregion

        #region Constructor

        public CompanyModel(string name)
        {
            this.Variants = new ObservableCollection<VariantModel>();
            this.Name = name;
        }

        #endregion

        #region Private Methods

        private void AddVariant(VariantModel variant)
        {
            this.Variants.Add(variant);
        }

        #endregion
    }
}
