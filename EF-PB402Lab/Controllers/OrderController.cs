using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_PB402Lab.Controllers
{
    internal class OrderController
    {
        private readonly IOrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderService();
        }

        public async Task Create()
        {

        }
    }
}
