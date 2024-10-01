using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entity
{
    public class CreateOrderDto 
    {
        public string Name { get; set; }
        public int ProductId { get; set; }

    }
}
