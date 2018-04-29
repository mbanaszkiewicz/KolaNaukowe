using AutoMapper;
using KolaNaukowe.web.Dtos;
using KolaNaukowe.web.Models;
using KolaNaukowe.web.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace KolaNaukowe.web.Services
{
    public class StudentResearchGroupService : IStudentResearchGroupService
    {

        private readonly IGenericRepository<StudentResearchGroup> _genericRepository;
        private readonly IMapper _mapper;


        public StudentResearchGroupService(IGenericRepository<StudentResearchGroup> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public StudentResearchGroupDto Add(StudentResearchGroup newStudentResearchGroup)
        {
            var studentResearchGroup = _genericRepository.Add(newStudentResearchGroup);
            return _mapper.Map<StudentResearchGroup, StudentResearchGroupDto>(studentResearchGroup);
        }

       
        public StudentResearchGroupDto Get(int id)
        {
            var studentResearchGroup = _genericRepository.Get(id);
            return _mapper.Map<StudentResearchGroup, StudentResearchGroupDto>(studentResearchGroup);
        }

        public IEnumerable<StudentResearchGroupDto> GetAll()
        {
            var studentResearchGroups = _genericRepository.GetAll().OrderBy(c => c.Name);                   
            return _mapper.Map<IEnumerable<StudentResearchGroup>, IEnumerable<StudentResearchGroupDto>>(studentResearchGroups);                      
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
