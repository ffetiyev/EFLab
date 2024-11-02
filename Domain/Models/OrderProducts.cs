using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderProducts:BaseEntity
    {
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public string OrdersId { get; set; }
        public Order Order { get; set; }
    }
}
