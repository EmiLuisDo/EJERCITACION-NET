using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Services;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Repositories;

namespace SupermarketAPI.Services
{
    public class CategoryService : IcategoryService
    {
            private readonly IcategoryRepository _categoryRepository;

            public CategoryService(IcategoryRepository categoryRepository)
            {
                _categoryRepository = categoryRepository;
            }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}