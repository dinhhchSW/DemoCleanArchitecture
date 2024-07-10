using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GadgetService : IGadgetService
    {
        private readonly IGadgetRepository _gadgetRepository;
        private readonly IMapper _mapper;

        public GadgetService(IGadgetRepository gadgetRepository, IMapper mapper)
        {
            _gadgetRepository = gadgetRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GadgetDto>> GetGadgetsByBrandAsync(string brand)
        {
            var gadgets = await _gadgetRepository.GetByBrandAsync(brand);
            return _mapper.Map<IEnumerable<GadgetDto>>(gadgets);
        }

        public async Task<GadgetDto?> GetByIdAsync(int id)
        {
            var gadget = await _gadgetRepository.GetByIdAsync(id);
            return _mapper.Map<GadgetDto>(gadget);
        }

        public async Task<IEnumerable<GadgetDto>> GetAllAsync()
        {
            var gadgets = await _gadgetRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<GadgetDto>>(gadgets);
        }

        //public async Task AddAsync(GadgetDto gadgetDto)
        //{
        //    var gadget = _mapper.Map<Gadget>(gadgetDto);
        //    _gadgetRepository.Add(gadget);
        //    await _gadgetRepository.SaveChangesAsync();
        //}

        public async Task<GadgetDto> AddAsync(GadgetDto dto)
        {
            var gadget = _mapper.Map<Gadget>(dto);
            _gadgetRepository.Add(gadget);
            await _gadgetRepository.SaveChangesAsync();
            return _mapper.Map<GadgetDto>(gadget);
        }



        public async Task UpdateAsync(GadgetDto gadgetDto)
        {
            var gadget = _mapper.Map<Gadget>(gadgetDto);
            _gadgetRepository.Update(gadget);
            await _gadgetRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var gadget = await _gadgetRepository.GetByIdAsync(id);
            if (gadget != null)
            {
                _gadgetRepository.Delete(gadget);
                await _gadgetRepository.SaveChangesAsync();
            }
        }

        
    }
}
