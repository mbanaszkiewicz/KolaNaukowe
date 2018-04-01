using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolaNaukowe.API.Data;
using KolaNaukowe.API.Models;

namespace KolaNaukowe.API.Services
{
    public class StudentResearchGroupData : IStudentResearchGroupData
    {
        List<StudentResearchGroup> _studentResearchGroups;
        private KolaNaukoweDBContext _context;

        public StudentResearchGroupData(KolaNaukoweDBContext context)
        {
            _context = context;
        }

        /*
        public StudentResearchGroupData()
        {
            _studentResearchGroups = new List<StudentResearchGroup>
            {
                new StudentResearchGroup { Id = 1, Name = "EKA.NET"},
                new StudentResearchGroup { Id = 2, Name = "Piast.NET"},
                new StudentResearchGroup { Id = 3, Name = "Jakieś randomy"},
            };
        }*/

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

        public void Update(StudentResearchGroup studentResearchGroup)
        {
        }
    }
}
