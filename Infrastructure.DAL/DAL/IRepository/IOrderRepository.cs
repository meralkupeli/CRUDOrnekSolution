using CRUD.Domain.Entity;

namespace CRUD.Infrastructure.DAL.IRepository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();

        Order GetOrder(int id);

        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
