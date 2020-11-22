using AutoMapper;
using DevBase.Business.Asbtract;
using DevBase.Dto.DTOs.CategoryDto;
using DevBase.Entities.ORM.Concerte;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBase.UI.Controllers
{
    public class CategoryController : Controller
    {

        private readonly IBaseService<Category> _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(IBaseService<Category> categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(_mapper.Map<List<CategoryListDto>>(_categoryService.GetAll()));
        }

        public IActionResult AddCategory()
        {
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddCategory(CategoryAddDto model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(_mapper.Map<Category>(model));
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult UpdateCategory(int id)
        {

            return View(_mapper.Map<CategoryUpdateDto>(_categoryService.GetByid(id)));
        }


        [HttpPost,AutoValidateAntiforgeryToken]
        public IActionResult UpdateCategory(CategoryUpdateDto model)
        {

            if (ModelState.IsValid)
            {
                _categoryService.Update(_mapper.Map<Category>(model));
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult DeleteCategory(int id)
        {
            _categoryService.Delete(_categoryService.GetByid(id));

            return RedirectToAction("Index");
            

            
        }
    }
}
