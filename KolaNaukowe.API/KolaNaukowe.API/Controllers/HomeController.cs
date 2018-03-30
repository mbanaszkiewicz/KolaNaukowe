using KolaNaukowe.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.API.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private IStudentResearchGroupData _studentResearchGroupData;

        public HomeController(IStudentResearchGroupData studentResearchGroupData)
        {
            _studentResearchGroupData = studentResearchGroupData;
        }

        public IActionResult Index()
        {
            var model = _studentResearchGroupData.GetAll();

            return View(model);
        }
    }
}
