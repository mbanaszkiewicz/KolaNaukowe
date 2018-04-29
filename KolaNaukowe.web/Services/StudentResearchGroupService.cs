using KolaNaukowe.web.Models;
using KolaNaukowe.web.Repositories;
using System.Collections.Generic;

namespace KolaNaukowe.web.Services
{
    public class StudentResearchGroupService : IStudentResearchGroupService
    {

        private readonly IGenericRepository<StudentResearchGroup> _genericRepository;

        public StudentResearchGroupService(IGenericRepository<StudentResearchGroup> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public StudentResearchGroup Add(StudentResearchGroup student)
        {
            return _genericRepository.Add(student);
        }

       
        public StudentResearchGroup Get(int id)
        {
            return _genericRepository.Get(id);
        }

        public IEnumerable<StudentResearchGroup> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public void Remove(int id)
        {
            _genericRepository.Remove(id);
        }

        public void Update(StudentResearchGroup item)
        {
            _genericRepository.Update(item);
        }

      

       
    }
}
