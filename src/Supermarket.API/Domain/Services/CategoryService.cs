using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRespository _categoryRespository;

        public CategoryService(ICategoryRespository categoryRespository)
        {
            _categoryRespository = categoryRespository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRespository.ListAsync();

        }


    }
}