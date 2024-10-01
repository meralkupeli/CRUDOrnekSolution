using CRUD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infrastructure.DAL.DBContext
{
    public static class SeedData
    {
        public static void Initialize(DatabaseContext context)
        {
            if (context.Products.Any())
            {
                return;   // Veritabanı zaten doldurulmuş.
            }

            context.Products.AddRange(
                new Product { Name = "TV", Price = 9.99M, Description="mük oldu aşko" },
                new Product { Name = "Playstation", Price = 19.99M, Description = "mük oldu aşko" },
                new Product { Name = "Bilgisayar", Price = 29.99M, Description = "mük oldu aşko" }
            );

            //Kaydetmek db ye
            context.SaveChanges();
        }
    }
}
