using KolaNaukowe.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.API.Services
{
    public interface IStudentResearchGroupData
    {
        IEnumerable<StudentResearchGroup> GetAll();
        StudentResearchGroup Get(int id);
        void Add(StudentResearchGroup studentResearchGroup);
        void Update(StudentResearchGroup studentResearchGroup);
        void Remove(int id);
    }
}
