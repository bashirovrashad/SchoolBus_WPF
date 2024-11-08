using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Entities_.Abstarcts_
{
    public abstract class Base_Person_Entity:Base_Entity
    {
        public string FirstName { get; set; }       
        public string LastName { get; set; }
    }
}
