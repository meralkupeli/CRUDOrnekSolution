using CRUD.Domain.Entity;

namespace CRUD.Infrastructure.DAL.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();

        Product GetProduct(int id);

        void Add(Product Product);
        void Update(Product Product);
        void Delete(Product Product);
    }
}
