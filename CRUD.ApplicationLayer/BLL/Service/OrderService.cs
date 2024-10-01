using CRUD.ApplicationLayer.BLL.IRepository;
using CRUD.Domain.Entity;
using CRUD.Infrastructure.DAL.IRepository;
using CRUD.Model.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.ApplicationLayer.BLL.Repository
{
    public class OrderService : IOrderService
    {
        #region Dependecy Injection
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        private readonly IOrderProductRepository orderProductRepository;

        //Dependecy İnjection
        public OrderService(IOrderRepository orderRepository,
            IProductRepository productRepository,
            IOrderProductRepository orderProductRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.orderProductRepository = orderProductRepository;
        }
        #endregion

        public void Add(CreateOrderDto order)
        {
            var product = productRepository.GetProduct(order.ProductId);
            if(product != null)
            {
                var _order = new Order { Name = order.Name };
                orderRepository.Add(_order);
                orderProductRepository.Add(new Order {OrderId=_order.Id , ProductId=product.Id});

                //productRepositoryKaydet
            }
           
        }

        public void Delete(DeleteOrderDto order)
        {
            var _order = orderRepository.GetOrder(order.Id);

            if(_order != null)
            {
                orderRepository.Delete(_order);
            }
        }

        public OrderDto GetOrder(int id)
        {
            var _order = orderRepository.GetOrder(id);

            if(_order != null)
            {
                return new OrderDto
                {
                    CreateDate = _order.CreateDate,
                    Name = _order.Name,
                };
            }

            return null;
        }

        public List<OrderDto> GetOrders()
        {
           var orders =  orderRepository.GetOrders();

           return orders.Select(x => new OrderDto
            {

                CreateDate = x.CreateDate,
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }

        public void Update(UpdateOrderDto order)
        {
            var _order = orderRepository.GetOrder(order.Id);

            _order.Name = order.Name;
            _order.CreateDate = DateTime.Now;

            orderRepository.Update(_order);
        }
    }
}
