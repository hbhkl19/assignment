using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using assignment9.Controllers;
using assignment9.Models;
using assignment9.Service;

namespace assignment9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
            _orderService.InitializeSampleData(); // 初始化测试数据
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_orderService.GetAllOrders());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _orderService.GetOrder(id);
            return order != null ? Ok(order) : NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateOrderRequest request)
        {
            try
            {
                var order = _orderService.CreateOrder(request.CustomerId, request.Items);
                return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _orderService.DeleteOrder(id);
            return NoContent();
        }
    }

    public class CreateOrderRequest
    {
        public int CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
