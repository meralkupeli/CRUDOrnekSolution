using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Domain.Entity;

namespace CRUD.Model.Model.Product
{
    public class CreateProductDto :BaseModel
    {
        public object ProductId;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

    }
}
