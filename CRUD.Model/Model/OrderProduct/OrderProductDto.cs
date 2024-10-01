using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Domain.Entity;
using CRUD.Model.Model.Product;
using CRUD.Model.Model.Order; 


namespace CRUD.Model.Model.OrderProduct
{
    public class OrderProductDto : BaseModel
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int OrderId { get; set; }
        public OrderDto Order { get; set; }
    }
}
