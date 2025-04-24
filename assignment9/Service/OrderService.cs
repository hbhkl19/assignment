using assignment9.Models;

namespace assignment9.Service
{
    public class OrderService
    {
        private static readonly List<Order> _orders = new();
        private static readonly List<Customer> _customers = new();
        private static readonly List<Product> _products = new();
        private static int _orderIdCounter = 1;

        // 订单操作
        public Order CreateOrder(int customerId, List<OrderItem> items)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
                throw new ArgumentException("Customer not found");

            var order = new Order
            {
                Id = _orderIdCounter++,
                CustomerId = customerId,
                Items = new List<OrderItem>(),
                OrderDate = DateTime.Now
            };

            decimal total = 0;
            foreach (var item in items)
            {
                var product = _products.FirstOrDefault(p => p.Id == item.ProductId);
                if (product == null)
                    throw new ArgumentException($"Product {item.ProductId} not found");

                if (product.Stock < item.Quantity)
                    throw new ArgumentException($"Insufficient stock for product {product.Name}");

                product.Stock -= item.Quantity;
                total += product.Price * item.Quantity;
                order.Items.Add(item);
            }

            order.TotalAmount = total;
            _orders.Add(order);
            return order;
        }

        public IEnumerable<Order> GetAllOrders() => _orders;

        public Order GetOrder(int id) => _orders.FirstOrDefault(o => o.Id == id);

        public void DeleteOrder(int id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
                _orders.Remove(order);
        }

        // 初始化测试数据
        public void InitializeSampleData()
        {
            _customers.Add(new Customer { Id = 1, Name = "Alice", Contact = "alice@example.com" });
            _customers.Add(new Customer { Id = 2, Name = "Bob", Contact = "bob@example.com" });

            _products.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99m, Stock = 10 });
            _products.Add(new Product { Id = 2, Name = "Mouse", Price = 29.99m, Stock = 50 });
        }
    }
}
