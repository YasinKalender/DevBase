using DevBase.Business.Asbtract;
using DevBase.DAL.Context;
using DevBase.DAL.Repository.Abstract;
using DevBase.DAL.UnitOfWork;
using DevBase.Entities.ORM.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Business.Concrete
{
    public class CategoryManager : BaseManager<Category>, ICategoryService
    {
    
        private ICategoryRepository _categoryRepository;


        public CategoryManager(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository) :base(unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }
        public List<Category> Search(string s)
        {
            return _categoryRepository.Search(s);
        }
    }
}
