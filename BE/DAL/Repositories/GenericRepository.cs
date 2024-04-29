using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private LibraryDbContext _libraryDbContext;
        private DbSet<T> _dbSet;

        public GenericRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
            _dbSet = _libraryDbContext.Set<T>();
        }

        public void Delete(int id)
        {
            T? exist = _dbSet.Find(id);
            if(exist != null)
            {
                _dbSet.Remove(exist);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {

          return _dbSet.Find(id);
        }

        public void Insert(T? obj)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));
            _dbSet.Add(obj);

        }

        public void Save()
        {
            _libraryDbContext.SaveChanges();
        }

        public void Update(T? obj)
        {
            if (null == obj) throw new ArgumentNullException(nameof(obj));
            _libraryDbContext.Entry(obj).State = EntityState.Modified;
            _libraryDbContext.Update(obj);
        }
    }
}
