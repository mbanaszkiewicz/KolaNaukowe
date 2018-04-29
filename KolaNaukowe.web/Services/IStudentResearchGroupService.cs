using KolaNaukowe.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Services
{
    public interface IStudentResearchGroupService
    {
        IEnumerable<StudentResearchGroup> GetAll();
        StudentResearchGroup Get(int id);
        StudentResearchGroup Add(StudentResearchGroup item);
        void Update(StudentResearchGroup item);
        void Remove(int id);
    }
}
