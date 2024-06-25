using Microsoft.EntityFrameworkCore;
using MyContactAPI.Repositories.Interfaces;
using System.Collections.Generic;

namespace MyContactAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //protected EmployeeDBContext _context = null;
        //The following Variable is going to hold the DbSet Entity
        protected DbSet<T> table = null;

        public GenericRepository()
        {
            //this._context = new EmployeeDBContext();
     
            //table = _context.Set<T>();
        }
        //public GenericRepository(EmployeeDBContext _context)
        //{
        //    this._context = _context;
        //    table = _context.Set<T>();
        //}

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T model)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
