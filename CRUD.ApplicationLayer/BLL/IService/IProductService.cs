using CRUD.Domain.Entity;
using CRUD.Model.Model.Product;

namespace CRUD.ApplicationLayer.BLL.IRepository
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();

        ProductDto GetProduct(int id);

        void Add(CreateProductDto product);
        void Update(UpdateProductDto product);
        void Delete(DeleteProductDto product);
    }
}
