using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KolaNaukowe.web.Models;
using KolaNaukowe.web.Data;

namespace KolaNaukowe.web.Controllers
{
    public class HomeController : Controller
    {
        private IStudentResearchGroupService _service;

        public HomeController(IStudentResearchGroupService service)
        {
            _service = service;
        }

        public IActionResult PrintAll()
        {
            var group = new StudentResearchGroup()
            {
                Name = "EKA.NET",
                CreatedAt = DateTime.UtcNow,
            };

            _service.Add(group);
            var model = _service.GetAll();

            return View(model);
        }

        public IActionResult Index()
        {
                   
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
