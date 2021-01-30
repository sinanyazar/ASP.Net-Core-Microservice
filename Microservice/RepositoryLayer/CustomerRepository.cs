using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace RepositoryLayer
{
   public class CustomerRepository : GenericRepository<Customers>, ICustomerRepository
    {
        public CustomerRepository(DataContext dataContext): base(dataContext)
        {

        }
    }
}
