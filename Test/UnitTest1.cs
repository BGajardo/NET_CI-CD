
using CI_CD.DTOs.Product;

using CI_CD.Entity;

using CI_CD.Repository;
using CI_CD.Service;

using Moq;


namespace Test
{
    public class ProductServiceTests
    {
        [Fact]
        public async Task AddProductAsync_ShouldCallRepositoryOnce()
        {
      
            var mockRepo = new Mock<IProductRepository>();
            var service = new ProductService(mockRepo.Object);

            var dto = new AddProductDTO { Name = "Mouse", Price = 10 };

            
            await service.AddProductAsync(dto);

          
            mockRepo.Verify(r => r.addAsync(It.IsAny<Product>()), Times.Never);
        }
    }
}
