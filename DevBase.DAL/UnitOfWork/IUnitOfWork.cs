using DevBase.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {

        IBaseRepository<T> GetRepository<T>() where T : class, new();
        void SaveChanges();
    }
}
