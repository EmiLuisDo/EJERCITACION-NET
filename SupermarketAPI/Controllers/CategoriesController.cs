using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services;

namespace SupermarketAPI.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesControllers : Controller
    {
        private readonly IcategoryService _categoryService;
        public CategoriesControllers(IcategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }

        [HttpGet]
        public string holaMundo()
        {
            return "hola mundo";
        }
    }
}