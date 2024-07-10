using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IStudentService : IBaseService<StudentDto>
    {
        //Task<StudentDto?> GetStudentByIdAsync(int id);
        //Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
        //Task AddStudentAsync(StudentDto studentDto);
        //Task UpdateStudentAsync(StudentDto studentDto);
        //Task DeleteStudentAsync(int id);
    }
}
