using CI_CD.DTOs.Product;

namespace CI_CD.Service
{
    public interface IProductService
    {
        Task<bool> AddProductAsync(AddProductDTO product);
        Task<IEnumerable<ProductDTO>> getAllProductsAsync();
    }
}
