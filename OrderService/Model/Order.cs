using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public int OrderAmout { get; set; }

        public string OrderDate { get; set; }
    }
}
