using CRUD.Domain.Entity;
using CRUD.Model.Model.Order;

namespace CRUD.ApplicationLayer.BLL.IRepository
{
    public interface IOrderService
    {
        List<OrderDto> GetOrders();

        OrderDto GetOrder(int id);

        void Add(CreateOrderDto order);
        void Update(UpdateOrderDto order);
        void Delete(DeleteOrderDto order);
    }
}
