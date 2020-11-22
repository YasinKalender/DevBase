using AutoMapper;
using DevBase.Business.Asbtract;
using DevBase.Dto.DTOs.CategoryDto;
using DevBase.Dto.DTOs.ProductDto;
using DevBase.Entities.ORM.Concerte;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DevBase.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBaseService<Product> _productService;
        private readonly IMapper _mapper;
        private readonly IBaseService<Category> _categoryService;

        public ProductController(IBaseService<Product> productService, IMapper mapper, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<ProductListDto>>(_productService.GetAll()));
        }

        public IActionResult AddProduct()
        {
            ViewBag.category = new SelectList(_categoryService.GetAll(), "ID", "CategoryName");

            return View();
        }


        [HttpPost,AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddProduct(ProductAddDto model, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    var images = Path.GetExtension(Image.FileName);
                    string guid = Guid.NewGuid()+images;

                    var addimages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/" + guid);

                    using (var stream = new FileStream(addimages, FileMode.Create))
                    {

                        await Image.CopyToAsync(stream);
                    }


                    _productService.Add(_mapper.Map<Product>(model));

                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }

        public IActionResult UpdateProduct(int id)
        {


            ViewBag.category = new SelectList(_categoryService.GetAll(),"ID", "CategoryName", "ID");

            return View(_mapper.Map<ProductUpdateDto>(_productService.GetByid(id)));
        }


        [HttpPost,AutoValidateAntiforgeryToken]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto model, IFormFile Image)
        {


            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    var images = Path.GetExtension(Image.FileName);
                    string guid = Guid.NewGuid() + images;

                    var addimages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/" + guid);

                    using (var stream = new FileStream(addimages, FileMode.Create))
                    {

                        await Image.CopyToAsync(stream);
                    }


                    _productService.Update(_mapper.Map<Product>(model));

                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }


        public IActionResult DeleteProduct(int id)
        {

            _productService.Delete(_productService.GetByid(id));
            return RedirectToAction("Index");
            
        }
    }
}
