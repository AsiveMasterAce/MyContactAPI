using Microsoft.EntityFrameworkCore;
using MyContactAPI.Data;
using MyContactAPI.Repositories.Interfaces;
using System.Collections.Generic;

namespace MyContactAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext _context = null;
        protected DbSet<T> table = null;

        public GenericRepository(ApplicationDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);

            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T model)
        {
            table.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T model)
        {

            table.Attach(model);

            _context.Entry(model).State = EntityState.Modified;
        }
    }
}
