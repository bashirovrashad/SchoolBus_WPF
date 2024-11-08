using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Entities_.Concretes_
{
    public class Ride :Base_Tool_Entity
    {
        public string Starting_Address { get; set; }
        public string Ending_Address { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
