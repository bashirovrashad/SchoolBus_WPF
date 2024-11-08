using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Entities_.Concretes_
{
    public class Car:Base_Tool_Entity
    {
        public string Number { get; set; }
        public int Seat_Count { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual ICollection<Student> Students { get; set;}
    }
}
