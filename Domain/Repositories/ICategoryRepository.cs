using System.Collections.Generic;
using supermarket_api.Domain.Models;
using System.Threading.Tasks;

namespace supermarket_api.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}