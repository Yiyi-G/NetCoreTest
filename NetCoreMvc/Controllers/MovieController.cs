using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreMvc.Controllers
{
    public class MovieController : Controller
    {
        private readonly NetCoreLibrary.Data.TestCoreDBContext _TestCoreDBContext;
        public MovieController(NetCoreLibrary.Data.TestCoreDBContext testCoreDBContext)
        {
            _TestCoreDBContext = testCoreDBContext;
        }
        public IActionResult Index()
        {
            var movies = _TestCoreDBContext.Movies;
            //    .Select(p => new
            //{
            //    p.Id,
            //    p.Title,
            //    p.Price,
            //    p.ReleaseDate,

            //});
            return View(movies);
        }
    }
}