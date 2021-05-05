using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Repositories;
using SupermarketAPI.Persistence.Contexts;

namespace SupermarketAPI.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, IcategoryRepository
    {

        public CategoryRepository (AppDbContext context): base(context) 
        {}

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}