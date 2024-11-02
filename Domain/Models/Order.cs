using Domain.Common;

namespace Domain.Models
{
    public class Order :BaseEntity
    {
        public int Count { get; set; }
        public DateTime OrderDate { get; set; }= DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; } = DateTime.Now;
        public bool isDelete { get; set; }= false;
        List<OrderProducts> Orders = new List<OrderProducts>();


    }
}
