using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Entities_.Concretes_
{
    public class Driver: Base_Person_Entity
    {
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Home_Address { get; set; }
        public string Licence { get; set; }
        
        public int CarId { get; set; }
        public int RideId { get; set; }
        public virtual Car Car { get; set; }
        public virtual Ride Ride { get; set; }

        

    }
}
