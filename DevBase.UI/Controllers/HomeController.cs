using AutoMapper;
using DevBase.Business.Asbtract;
using DevBase.Business.NLog;
using DevBase.Dto.DTOs.ProductDto;
using DevBase.Entities.ORM.Concerte;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevBase.UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly INLog _nLog;
   
        public HomeController(INLog nLog)
        {
            _nLog = nLog;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {

            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            _nLog.Eror($"Hata yeri{exceptionHandler.Path} Hata mesajı:{exceptionHandler.Error.Message} Stack:{exceptionHandler.Error.StackTrace}");

            ViewBag.hata = exceptionHandler.Path;
            ViewBag.mesaj = exceptionHandler.Error.Message;

            return View();
        }




    }
}
