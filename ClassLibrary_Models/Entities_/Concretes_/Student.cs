using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Entities_.Concretes_
{
    public class Student:Base_Person_Entity
    {
        public string Home_Address { get; set; }
        public string? Other_Address { get; set; }
        public int Class_Id { get; set; }
        public int ParentId { get; set; }
        public int? CarId { get; set; } = 0;
        public virtual Class_ Class_ { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual Car? Car { get; set; }
    }
}
