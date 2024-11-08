using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Entities_.Concretes_
{
    public class Parent:Base_Person_Entity
    {
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
