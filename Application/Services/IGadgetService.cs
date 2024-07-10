using Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IGadgetService : IBaseService<GadgetDto>
    {
        Task<IEnumerable<GadgetDto>> GetGadgetsByBrandAsync(string brand);
    }

    
}
