using KolaNaukowe.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        Student Add(Student item);
        void Update(Student item);
        void Remove(int id);
    }
}
