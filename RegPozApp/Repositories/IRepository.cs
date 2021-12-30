using System.Collections.Generic;

namespace RegPozApp.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        T Get(int id);
        List<T> GetAll();
        void Delete(int id);
        void SaveChanges();
    }
}
