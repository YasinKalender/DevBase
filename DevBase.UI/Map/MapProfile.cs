using AutoMapper;
using DevBase.Dto.DTOs.CategoryDto;
using DevBase.Dto.DTOs.ProductDto;
using DevBase.Entities.ORM.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBase.UI.Map
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductListDto>();
            CreateMap<ProductListDto, Product>();
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();
            CreateMap<Product, ProductUpdateDto>();
            CreateMap<ProductUpdateDto, Product>();


            CreateMap<Category, CategoryAddDto>();
            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryListDto>();
            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();
            CreateMap<CategoryUpdateDto, Category>();



        }

    }
}
