using CRUD.Domain.Entity;
using CRUD.Infrastructure.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infrastructure.DAL.IRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext databaseContext;

        public ProductRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void Add(Product Product)
        {
            databaseContext.Add(Product);
        }

        public void Delete(Product Product)
        {
             databaseContext.Remove(Product);
        }

        public Product GetProduct(int id)
        {
            return databaseContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            return databaseContext.Products.ToList();
        }


        public void Update(Product Product)
        {
            databaseContext.Update(Product);
        }
    }
}
