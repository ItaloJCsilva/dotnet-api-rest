using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Domain.Controllers


{
    public class CategoriesController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CategoriesController : Controller
        {
            private readonly ICategoryService _categoryService;

            public CategoriesController(ICategoryService categoryService)
            {
                _categoryService = categoryService;
            }

            [HttpGet]
            public async Task<IEnumerable<Category>> GetAllAsync()
            { 
                var categories = await _categoryService.ListAsync();
                return categories;
            }
        }
        

    }
}