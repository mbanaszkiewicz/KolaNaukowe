using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolaNaukowe.API.Models;

namespace KolaNaukowe.API.Services
{
    public class StudentResearchGroupData : IStudentResearchGroupData
    {
        List<StudentResearchGroup> _studentResearchGroups;

        public StudentResearchGroupData()
        {
            _studentResearchGroups = new List<StudentResearchGroup>
            {
                new StudentResearchGroup { Id = 1, Name = "EKA.NET"},
                new StudentResearchGroup { Id = 2, Name = "Piast.NET"},
                new StudentResearchGroup { Id = 3, Name = "Jakieś randomy"},
            };
        }

        public void Add(StudentResearchGroup studentResearchGroup)
        {
            _studentResearchGroups.Add(studentResearchGroup);
        }

        public StudentResearchGroup Get(int id)
        {
            return _studentResearchGroups.Single(x => x.Id == id);
        }

        public IEnumerable<StudentResearchGroup> GetAll()
        {
            return _studentResearchGroups.OrderBy(x => x.Name);
        }

        public void Remove(int id)
        {
            var studentResearchGroup = Get(id);
            _studentResearchGroups.Remove(studentResearchGroup);
        }

        public void Update(StudentResearchGroup studentResearchGroup)
        {
        }
    }
}
