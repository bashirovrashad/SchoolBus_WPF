using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Data_Access.Repositories_.Interfaces_
{
    public interface IBase_Repos<T> where T : Base_Entity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(int id);
        T? GetById(int id);
        ICollection<T>? GetAll();
        void SaveChanges();
    }
}
