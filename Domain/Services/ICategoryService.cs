using System.Threading.Tasks;
using System.Collections.Generic;
using supermarket_api.Domain.Models;

namespace supermarket_api.Domain.Services
{
    /*
        The implementations of the ListAsync method must asynchronously return an enumeration of categories.
        The Task class, encapsulating the return, indicates asynchrony. 
        We need to think in an asynchronous method due to the fact that 
        we have to wait for the database to complete some operation to return the data, 
        and this process can take a while. Notice also the “async” suffix. 
        It’s a convention that indicates that our method should be executed asynchronously.
    */

    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}
