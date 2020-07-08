using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Model;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace OrderService.Controllers
{
    public class OrderController : ControllerBase
    {
        [HttpGet("orders/{id}")]
        public ActionResult GetOrder([FromUri] int id)
        {
            var orders = new List<Order>();

            var order1 = new Order()
            {
                OrderId = 1,
                OrderAmout = 250,
                OrderDate = "14-Apr-2020"
            };

            var order2 = new Order()
            {
                OrderId = 2,
                OrderAmout = 450,
                OrderDate = "15-Apr-2020"
            };
            orders.Add(order1);
            orders.Add(order2);
            return StatusCode((int)HttpStatusCode.OK, orders);
        }
    }
}
