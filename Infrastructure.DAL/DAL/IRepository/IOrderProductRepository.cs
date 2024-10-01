using CRUD.Domain.Entity;

namespace CRUD.Infrastructure.DAL.IRepository
{
    public interface IOrderProductRepository
    {
        List<Order> GetOrderProducts();

        Order GetOrderProduct(int id);

        void Add(OrderProduct orderProduct);
        void Update(OrderProduct orderProduct);
        void Delete(OrderProduct orderProduct);
    }
}
