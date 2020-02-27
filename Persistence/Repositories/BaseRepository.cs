using supermarket_api.Persistence.Contexts;

namespace supermarket_api.Persistence.Repositories
{

    /*
        WHat this class does?
        
        This class is just an abstract class that all our repositories will inherit. 
        An abstract class is a class that don’t have direct instances. 
        You have to create direct classes to create the instances.

        The BaseRepository receives an instance of our AppDbContext through dependency injection 
        and exposes a protected property (a property that can only be accessible by the children classes) 
        called _context, that gives access to all methods we need to handle database operations.
    /*/

    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext DBContext)
        {
            _context = DBContext;
        }       
    }
}