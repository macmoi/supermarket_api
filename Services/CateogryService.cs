using System.Threading.Tasks;
using System.Collections.Generic;
using supermarket_api.Domain.Models;
using supermarket_api.Domain.Services;
using supermarket_api.Domain.Repositories;

namespace supermarket_api.Services
{
    public class CateogryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CateogryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}