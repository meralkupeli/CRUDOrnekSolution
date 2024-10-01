using CRUD.ApplicationLayer.BLL.IRepository;
using CRUD.Domain.Entity;
using CRUD.Infrastructure.DAL.IRepository;
using CRUD.Model.Model.Order;
using CRUD.Model.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.ApplicationLayer.BLL.Repository
{
    public class ProductService : IProductService
    {
        #region Dependecy Injection
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        //Dependecy İnjection
        public ProductService(IProductRepository productRepository,
          IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }
        #endregion

        public void Add(CreateProductDto product)
        {
            var products = productRepository.GetProduct((int)product.ProductId);
            if(products == null)
            {
                var _product = new Product { Name = product.Name };
                productRepository.Add(_product);

                //productRepositoryKaydet
            }
           
        }

      

        public void Delete(DeleteProductDto product)
        {
            var _product = productRepository.GetProduct(product.Id);

            if(_product != null)
            {
                productRepository.Delete(_product);
            }
        }

     

        public ProductDto GetProduct(int id)
        {
            var _product = productRepository.GetProduct(id);

            if(_product != null)
            {
                return new ProductDto
                {
                    CreatedDate = _product.CreatedDate,
                    Name = _product.Name,
                };
            }

            return null;
        }

        public List<ProductDto> GetProducts()
        {
           var products =  productRepository.GetProducts();

           return products.Select(x => new ProductDto
            {

                CreatedDate = x.CreatedDate,
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }


        public void Update(UpdateProductDto product)
        {
            var _product = productRepository.GetProduct(product.Id);

            _product.Name = product.Name;
            _product.CreatedDate = DateTime.Now;

            productRepository.Update(_product);
        }

    }
}
