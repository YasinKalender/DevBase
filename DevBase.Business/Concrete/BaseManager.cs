using DevBase.Business.Asbtract;
using DevBase.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Business.Concrete
{
    public class BaseManager<T> : IBaseService<T> where T:class,new()
    {

        private readonly IUnitOfWork _unitOfWork;

        public BaseManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            _unitOfWork.GetRepository<T>().Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(T entity)
        {
            _unitOfWork.GetRepository<T>().Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public List<T> GetAll()
        {
           return _unitOfWork.GetRepository<T>().GetAll();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _unitOfWork.GetRepository<T>().GetAll(expression);
        }

        public T GetByid(int id)
        {
            return _unitOfWork.GetRepository<T>().GetByid(id);
        }

        public T GetOne(Expression<Func<T, bool>> expression)
        {
            return _unitOfWork.GetRepository<T>().GetOne(expression);
        }

        public void Update(T entity)
        {
            _unitOfWork.GetRepository<T>().Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
