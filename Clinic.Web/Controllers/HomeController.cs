using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clinic.Domain.Model;

namespace Clinic.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClinicDbContext _context;
        public HomeController(IClinicDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var x = _context.User.FirstOrDefault();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
