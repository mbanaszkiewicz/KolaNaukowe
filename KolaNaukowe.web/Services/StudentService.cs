using System.Collections.Generic;
using KolaNaukowe.web.Models;
using KolaNaukowe.web.Repositories;

namespace KolaNaukowe.web.Services
{
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Student> _genericRepository;

        public StudentService(IGenericRepository<Student> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Student Add(Student student)
        {
            return _genericRepository.Add(student);
        }

        public Student Get(int id)
        {
            return _genericRepository.Get(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public void Remove(int id)
        {
            _genericRepository.Remove(id);
        }

        public void Update(Student item)
        {
            _genericRepository.Update(item);
        }
    }
}
