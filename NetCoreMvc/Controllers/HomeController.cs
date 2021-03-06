﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NetCore.Commen;
using NetCoreMvc.Models;

namespace NetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           var serviceName = ConfigurationManager.Configuration["Log:ServiceName"];
            ViewBag.Titile = "my Home Index";
            ViewBag.serviceName = serviceName;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string Welcome(long id,string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes},Id is :{id}");
        }
    }
}
