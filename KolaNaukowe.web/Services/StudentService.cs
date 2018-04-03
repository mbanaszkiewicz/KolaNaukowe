using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolaNaukowe.web.Data;
using KolaNaukowe.web.Models;

namespace KolaNaukowe.web.Services
{
    public class StudentService : IStudentService
    {
        private KolaNaukoweDbContext _context;

        public StudentService(KolaNaukoweDbContext context)
        {
            _context = context;
        }

        public Student Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student Get(int id)
        {
            return _context.Students.Single(x => x.Id == id);

        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.OrderBy(x => x.Id);
        }

        public void Remove(int id)
        {
            var student = Get(id);
            _context.Students.Remove(student);
        }

        public void Update(int id)
        {
            var studentToUpdate = _context.StudentResearchGroups.SingleOrDefault(x => x.Id == id);
            studentToUpdate.Name = "new name";
            _context.SaveChanges();
        }
    }
}
