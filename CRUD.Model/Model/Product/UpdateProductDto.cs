using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Domain.Entity;

namespace CRUD.Model.Model.Product
{
    public class UpdateProductDto : BaseModel
    {
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
    
    }
}
