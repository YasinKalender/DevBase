using DevBase.Business.Asbtract;
using DevBase.Business.Concrete;
using DevBase.Business.NLog;
using DevBase.Business.ValidationRules;
using DevBase.DAL.Context;
using DevBase.DAL.Repository.Abstract;
using DevBase.DAL.Repository.Concrete;
using DevBase.DAL.UnitOfWork;
using DevBase.Dto.DTOs.CategoryDto;
using DevBase.Dto.DTOs.ProductDto;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Business.Configure
{
    public static class DependencyInjection
    {

        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddDbContext<ProjectContext>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseService<>),typeof(BaseManager<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<INLog, NLogs>();

            services.AddTransient<IValidator<CategoryAddDto>, CaetgoryAddValidation>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<ProductAddDto>, ProductAddValidaton>();






        }
    }
}
