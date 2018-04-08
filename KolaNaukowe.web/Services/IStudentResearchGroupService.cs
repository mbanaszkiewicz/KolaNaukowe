using KolaNaukowe.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web
{
    public interface IStudentResearchGroupService
    {
        IEnumerable<StudentResearchGroup> GetAll();
        StudentResearchGroup Get(int id);
        StudentResearchGroup Add(StudentResearchGroup studentResearchGroup);
        void Update(StudentResearchGroup studentGroup);
        void Remove(int id);
    }
}
