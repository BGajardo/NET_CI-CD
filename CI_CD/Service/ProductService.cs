
using CI_CD.DTOs.Product;
using CI_CD.Entity;
using CI_CD.Repository;

namespace CI_CD.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        
        public ProductService(IProductRepository repository) => _repository = repository;

        public async Task<bool> AddProductAsync(AddProductDTO product)
        {
            var entity = new Product
            {
                Name = product.Name,
                Price = product.Price,
            };

            return await _repository.addAsync(entity);
        }

        public async Task<IEnumerable<ProductDTO>> getAllProductsAsync()
        {
            var products = await _repository.getAllASync();

            return products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
            });

        }
    }
}
