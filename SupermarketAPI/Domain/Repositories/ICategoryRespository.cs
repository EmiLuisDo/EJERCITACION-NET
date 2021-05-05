using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Repositories
{
    public interface IcategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}