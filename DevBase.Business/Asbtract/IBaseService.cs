using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace DevBase.Business.Asbtract
{
    public interface IBaseService<T> where T:class
    {

        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> expression);

        T GetByid(int id);

        T GetOne(Expression<Func<T, bool>> expression);

        void Add(T entity);
        void Delete(T entity);

        void Update(T entity);
    }
}
