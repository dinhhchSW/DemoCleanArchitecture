using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{

    public class GadgetRepository : Repository<Gadget>, IGadgetRepository
    {
        private readonly DbSet<Gadget> _dbSet;
        public GadgetRepository(Context context) : base(context)
        {
            _dbSet = context.Set<Gadget>();
        }


        public async Task<IEnumerable<Gadget>> GetByBrandAsync(string brand)
        {
            return await _dbSet.Where(g => g.Brand == brand).ToListAsync();
        }
    }
}
