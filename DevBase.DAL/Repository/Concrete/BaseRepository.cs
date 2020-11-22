using DevBase.DAL.Context;
using DevBase.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.DAL.Repository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class,new()
    {

        private readonly ProjectContext _projectContext;

        public BaseRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public void Add(T entity)
        {
            _projectContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _projectContext.Set<T>().Remove(entity);
        }

        public List<T> GetAll()
        {
            return _projectContext.Set<T>().ToList();
           
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _projectContext.Set<T>().ToList();
        }

        public T GetByid(int id)
        {
            return _projectContext.Set<T>().Find(id);
        }

        public T GetOne(Expression<Func<T, bool>> expression)
        {
            return _projectContext.Set<T>().Where(expression).FirstOrDefault();
        }

        public void Update(T entity)
        {
            _projectContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
