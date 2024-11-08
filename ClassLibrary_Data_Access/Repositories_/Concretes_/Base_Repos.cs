using ClassLibrary_Data_Access.Contexts_;
using ClassLibrary_Data_Access.Repositories_.Interfaces_;
using ClassLibrary_Models.Entities_.Abstarcts_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Data_Access.Repositories_.Concretes_
{
    public class Base_Repos<T> : IBase_Repos<T> where T : Base_Entity, new()
    {
        internal readonly SchoolBusDB _context;

        public Base_Repos()
        {
            _context = new SchoolBusDB();
        }
        public void Add(T entity)
        {          
            _context.Set<T>().Add(entity);
        }

        public ICollection<T>? GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            return _context?.Set<T>().FirstOrDefault(a => a.Id == id);
        }

        public void Remove(T entity)
        {
            var ent = _context?.Set<T>().FirstOrDefault(a => a.Id == entity.Id);
            _context?.Set<T>().Remove(ent);
        }

        public void Remove(int id)
        {
            var ent = _context?.Set<T>().FirstOrDefault(a => a.Id == id);
            if (ent is not null) _context?.Set<T>().Remove(ent);


        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context?.Set<T>().Update(entity);
        }
    }
}
