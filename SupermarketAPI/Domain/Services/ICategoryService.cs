using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Services
{
    public interface IcategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }

}