using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KolaNaukowe.web.Models;
using KolaNaukowe.web.Data;
using Microsoft.AspNetCore.Authorization;

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
           
            var model = _service.GetAll();

            return View(model);
        }

        //testowe dane
        public IActionResult AddGroup()
        {

            var group = new StudentResearchGroup()
            {
                Name = "EKADOTNET",
                CreatedAt = DateTime.UtcNow,
            };

            _service.Add(group);
            return Ok();

        }

        //testowe dane
        public IActionResult UpdateGroup()
        {

            _service.Update("EKA.NET");
            return Ok();
        }

        public IActionResult Index()
        {
            var model = _service.GetAll();
            return View(model);
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
