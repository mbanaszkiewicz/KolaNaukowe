using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KolaNaukowe.web.Models;
using KolaNaukowe.web.Data;
using Microsoft.AspNetCore.Authorization;
using KolaNaukowe.web.Services;

namespace KolaNaukowe.web.Controllers
{
    public class HomeController : Controller
    {
        private IStudentResearchGroupService _studentResearchGroupService;
        private KolaNaukoweDbContext _context;

        public HomeController(IStudentResearchGroupService studentResearchGroupService, KolaNaukoweDbContext context)
        {
            _context = context;
            _studentResearchGroupService = studentResearchGroupService;

        }
        
        public IActionResult Index()
        {
            var model = _studentResearchGroupService.GetAll();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentResearchGroupService.Get(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [Authorize(Policy = "AdminOnly")]
        public IActionResult Create()
        {    
            return View();
        }


        [HttpPost]
        public IActionResult Create(StudentResearchGroup studentGroup)
        {         
                if (ModelState.IsValid)
                {
                _studentResearchGroupService.Add(studentGroup);
                    return RedirectToAction(nameof(Index));
                }
            return   View(studentGroup); 
        }

        [HttpPost]
        public IActionResult Delete(int id, StudentResearchGroup studentGroup)
        {
            if (ModelState.IsValid)
            {
                _studentResearchGroupService.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            return View(studentGroup);
        }
        [Authorize(Policy = "AdminOnly")]
        public IActionResult Delete()
        {
            return View();
        }
        [Authorize(Policy = "LeaderAndAdmin")]
        public IActionResult Edit()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Edit(int id, StudentResearchGroup studentGroup)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View(studentGroup);
        }

        [Authorize(Policy = "AdminOnly")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Contact()
        {
      
            ViewData["Message"] = "Contact";
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
