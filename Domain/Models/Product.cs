using Domain.Common;

namespace Domain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public bool isDelete { get; set; } = false;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; } = DateTime.Now;
        List<OrderProducts> Products = new List<OrderProducts>();

    }
}
