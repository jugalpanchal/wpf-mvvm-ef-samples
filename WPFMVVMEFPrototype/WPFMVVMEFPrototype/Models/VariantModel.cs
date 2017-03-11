using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMEFPrototype.Models
{
    class VariantModel : Model
    {
        public string Name { get; set; }
        public ObservableCollection<CarModel> Cars { get; set; }
    }
}
