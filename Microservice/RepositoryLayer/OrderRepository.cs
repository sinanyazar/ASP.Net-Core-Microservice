using Entities;

namespace RepositoryLayer
{
   public class OrderRepository: GenericRepository<Orders>, IOrderRepository
    {
        public OrderRepository(DataContext dataContext): base(dataContext)
        {
                
        }
    }
}
