using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Domain.Entity;

namespace CRUD.Model.Model.Order
{
    public class OrderDto : BaseModel
    {
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }

    }
}
