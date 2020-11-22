using DevBase.DAL.Context;
using DevBase.DAL.Repository.Abstract;
using DevBase.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBase.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private ProjectContext _projectContext;



        public UnitOfWork(ProjectContext projectContext)
        {
            _projectContext = projectContext;
   
        
        }

      

        public IBaseRepository<T> GetRepository<T>() where T : class,new()
        {
            return new BaseRepository<T>(_projectContext);
        }

        public void SaveChanges()
        {
            _projectContext.SaveChanges();
        }
    }
}
