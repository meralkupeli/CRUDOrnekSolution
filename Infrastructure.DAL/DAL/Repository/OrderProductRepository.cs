using CRUD.Domain.Entity;
using CRUD.Infrastructure.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infrastructure.DAL.IRepository
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly DatabaseContext databaseContext;

        public OrderProductRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void Add(Order orderproduct)
        {
            databaseContext.Add(orderproduct);
        }

        public void Delete(Order orderProduct)
        {
             databaseContext.Remove(orderProduct);
        }

        public Order GetOrderProduct(int id)
        {
            return databaseContext.OrderProducts.FirstOrDefault(x => x.Id == id);
        }

        public List<Order> GetOrderProducts()
        {
            return databaseContext.OrderProducts.ToList();
        }


        public void Update(Order orderProduct)
        {
            databaseContext.Update(orderProduct);
        }
    }
}
