using CRUD.Domain.Entity;
using CRUD.Infrastructure.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infrastructure.DAL.IRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseContext databaseContext;

        public OrderRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void Add(Order order)
        {
            databaseContext.Add(order);
        }

        public void Delete(Order order)
        {
             databaseContext.Remove(order);
        }

        public Order GetOrder(int id)
        {
            return databaseContext.Orders.FirstOrDefault(x => x.Id == id);
        }

        public List<Order> GetOrders()
        {
            return databaseContext.Orders.ToList();
        }


        public void Update(Order order)
        {
            databaseContext.Update(order);
        }
    }
}
