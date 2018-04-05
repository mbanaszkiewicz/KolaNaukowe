using KolaNaukowe.web.Data;
using KolaNaukowe.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Services
{
    public class StudentResearchGroupService : IStudentResearchGroupService
    {
        private KolaNaukoweDbContext _context;

        public StudentResearchGroupService(KolaNaukoweDbContext context)
        {
            _context = context;
            DbInitializer.Initialize(_context);
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
            var studentResearchGroup = Get(id);
            _context.StudentResearchGroups.Remove(studentResearchGroup);
        }

       //testowe dane
        public void Update(string name)
        {
            var studentResearchGroupToUpdate = _context.StudentResearchGroups.FirstOrDefault(x => x.Name == name);
            if (studentResearchGroupToUpdate == null)
                return;
            studentResearchGroupToUpdate.Name = "new name";
            _context.SaveChanges();
        }

      
    }
}
