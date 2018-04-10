using KolaNaukowe.web.Data;
using KolaNaukowe.web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Services
{
    public class StudentResearchGroupService : IStudentResearchGroupService
    {
        private KolaNaukoweDbContext _context;
 
        public StudentResearchGroupService(KolaNaukoweDbContext context, IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager)
        {
            _context = context;

            //przenioslem DBInitializer do Program.cs 
        }

        public StudentResearchGroup Add(StudentResearchGroup studentResearchGroup)
        {
            _context.StudentResearchGroups.Add(studentResearchGroup);
            _context.SaveChanges();
            return studentResearchGroup;
        }

    
        public StudentResearchGroup Get(int id)
        {
            return _context.StudentResearchGroups.Single(x => x.Id == id);
        }

        public IEnumerable<StudentResearchGroup> GetAll()
        {
            return _context.StudentResearchGroups.OrderBy(x => x.Name);
        }

        public void Remove(int id)
        {
            StudentResearchGroup studentGroup = _context.StudentResearchGroups.Find(id);
            _context.StudentResearchGroups.Remove(studentGroup);
            _context.SaveChanges();
        }

       //testowe dane
        public void Update(StudentResearchGroup studentGroup)
        {
            _context.Entry(studentGroup).State = EntityState.Modified;
            _context.SaveChanges();
        }

      
    }
}
