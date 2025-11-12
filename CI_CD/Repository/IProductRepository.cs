using CI_CD.Entity;

namespace CI_CD.Repository
{
    public interface IProductRepository
    {
        Task<bool> addAsync(Product product);
        Task<IEnumerable<Product>> getAllASync();
    }
}
