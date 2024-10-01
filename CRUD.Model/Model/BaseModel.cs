using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entity
{
    //Domain katmanı sadece Repository katmanında olmalı
    public class BaseModel
    {
        public int Id { get; set; }
    }
}
