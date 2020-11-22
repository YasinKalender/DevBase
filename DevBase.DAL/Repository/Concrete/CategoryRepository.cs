using DevBase.DAL.Context;
using DevBase.DAL.Repository.Abstract;
using DevBase.Entities.ORM.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.DAL.Repository.Concrete
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly ProjectContext _projectContext;

        public CategoryRepository(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public List<Category> Search(string s)
        {
          var result = _projectContext.Category.AsQueryable();

            if (!string.IsNullOrWhiteSpace(s))
            {
                result = result.Where(i => i.CategoryName.Contains(s));
            }

            return result.ToList();
        }
    }
}
