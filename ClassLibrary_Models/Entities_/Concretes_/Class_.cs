using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Entities_.Concretes_
{
    public class Class_:Base_Tool_Entity
    {
      
        public virtual ICollection<Student> Students { get; set; }
        public int Student_Count { get; set; } = 0;
    }
}
