using Microsoft.EntityFrameworkCore;
using RegPozApp.Data;
using RegPozApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegPozApp.Repositories
{
    public class GenericRepository<T>
        : IRepository<T> where T : Entity
    {
        protected DataContext _context;
        protected DbSet<T> _dbSet;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(int id)
        {
            var entity = this.Get(id);
            entity.IsDeleted = true;
            this.Update(entity);
        }

        public virtual T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
