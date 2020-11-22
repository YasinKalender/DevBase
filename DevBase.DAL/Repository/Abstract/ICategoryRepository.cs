using DevBase.Entities.ORM.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.DAL.Repository.Abstract
{
    public interface ICategoryRepository:IBaseRepository<Category>
    {
        List<Category> Search(string s);

    }
}
