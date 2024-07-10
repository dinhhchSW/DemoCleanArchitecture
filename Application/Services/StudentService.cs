using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IRepository<Student> studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentDto?> GetByIdAsync(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            return _mapper.Map<StudentDto>(student);
        }

        public async Task<IEnumerable<StudentDto>> GetAllAsync()
        {
            var students = await _studentRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        public async Task AddAsync(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);
            _studentRepository.Add(student);
            await _studentRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);
            _studentRepository.Update(student);
            await _studentRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student != null)
            {
                _studentRepository.Delete(student);
                await _studentRepository.SaveChangesAsync();
            }
        }

        Task<StudentDto> IBaseService<StudentDto>.AddAsync(StudentDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
