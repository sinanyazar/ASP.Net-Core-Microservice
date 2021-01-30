using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using OrderApiInfrastructure;

namespace OrderService
{
    public class OrderService : IOrder
    {
        public void Create(Orders orders)
        {
            throw new NotImplementedException();
        }

        public void Delete(Orders orders)
        {
            throw new NotImplementedException();
        }

        public List<Orders> Get()
        {
            throw new NotImplementedException();
        }

        public Orders Get(int id)
        {
            return new Orders()
            {
                Id = 1,
                CustomerId = 1,
                Price = 100,
                Quantity= 10
            };
        }

        public void Update(Orders orders)
        {
            throw new NotImplementedException();
        }
    }
}
