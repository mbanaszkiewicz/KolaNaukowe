using KolaNaukowe.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Services
{
    interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        Student Add(Student student);
        void Update(int id);
        void Remove(int id);
    }
}
