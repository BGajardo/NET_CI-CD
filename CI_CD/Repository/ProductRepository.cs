using CI_CD.Data;
using CI_CD.Entity;
using Microsoft.EntityFrameworkCore;

namespace CI_CD.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> addAsync(Product product) { 
            _context.Products.Add(product);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<IEnumerable<Product>> getAllASync()
        { 
            return await _context.Products.ToListAsync();
        }

    }
}
