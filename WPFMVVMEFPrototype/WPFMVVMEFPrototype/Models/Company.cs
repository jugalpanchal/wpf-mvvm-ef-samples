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
        public string Name { get; set; }
        public ObservableCollection<Variant> Variants { get; set; }
    }
}
