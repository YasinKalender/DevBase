using DevBase.Entities.ORM.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Business.Asbtract
{
    public interface ICategoryService:IBaseService<Category>
    {

        List<Category> Search(string s);
    }
}
