using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Services
{
    public interface IBaseService<TDto>
    {
        Task<TDto?> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> AddAsync(TDto dto);
        Task UpdateAsync(TDto dto);
        Task DeleteAsync(int id);
    }
}
