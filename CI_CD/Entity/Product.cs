using Microsoft.EntityFrameworkCore;

namespace CI_CD.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        
        [Precision(10, 2)]
        public decimal Price { get; set; }
    }
}
