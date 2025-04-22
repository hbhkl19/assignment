using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSource
{
    
    public class Order
    {
        public int orderNumber { get; set; }
        public Client client { get; set; } = new Client();
        public List<OrderDetails> Details { get; } = new List<OrderDetails>();
        public decimal Total => Details.Sum(d => d.SubTotal);
        public void AddDetail(OrderDetails detail)
        {
            if (Details.Contains(detail))
                throw new InvalidOperationException("订单明细已存在");
            Details.Add(detail);
        }

        public override bool Equals(object obj)
        {
            return obj is Order order
                && orderNumber == order.orderNumber
                && EqualityComparer<Client>.Default.Equals(client, order.client)
                && Details.SequenceEqual(order.Details);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(orderNumber, client);
        }
        public override string ToString()
        {
            return $"订单 [{orderNumber}]\n" +
                $"客户: {client}\n" +
                $"总金额： {Total:C}\n" +
                "明细：\n" +
                string.Join("\n", Details.Select(d => $"{d}"));
        }
    }

    public class Client
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Client client
                && Name == client.Name
                && Id == client.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Id);
        }

        public override string ToString()
        {
            return $"Client [{Id}] {Name}";
        }
    }

    public class OrderDetails
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; } //价格
        public int Quantity { get; set; }//数量
        public decimal SubTotal => Price * Quantity;

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details
                && ProductName == details.ProductName
                && Price == details.Price
                && Quantity == details.Quantity;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ProductName, Price, Quantity);
        }
        public override string ToString()
        {
            return $"{ProductName} x{Quantity} @{Price:C} (小计：{SubTotal:C})";
        }
    }

    public class OrderService
    {
        public List<Order> orders  = new List<Order>();
        public void AddOrder(Order order)
        {
            if (orders.Any(o => o.Equals(order)))
                throw new ArgumentException("订单已存在");
            var detailsSet = new HashSet<OrderDetails>();
            foreach (var detail in order.Details)
            {
                if (!detailsSet.Add(detail))
                    throw new ArgumentException("订单包含重复明细");
            }
            orders.Add(order);
        }
        public void RemoveOrder(int orderNumber)
        {
            var order = orders.FirstOrDefault(o => o.orderNumber == orderNumber);
            if (order == null)
                throw new KeyNotFoundException($"订单{orderNumber}不存在");
            orders.Remove(order);
        }
        public void UpdateOrder(Order newOrder)
        {
            var index = orders.FindIndex(o => o.orderNumber == newOrder.orderNumber);
            if (index == -1)
                throw new KeyNotFoundException($"订单 {newOrder.orderNumber}不存在");
            if (orders.Any(o => o != orders[index]) && orders.Equals(newOrder))
                throw new ArgumentException("更新后的订单与其他的订单冲突");
            orders[index] = newOrder;
        }
        //默认查询
        public IEnumerable<Order> QueryAll() => orders.OrderBy(o => o.Total);
        //订单号查询
        public IEnumerable<Order> QueryByNumber(int number) =>
            orders.Where(o => o.orderNumber == number)
            .OrderBy(o => o.Total);
        //商品名称查询
        public IEnumerable<Order> QueryByProduct(string product) =>
            orders.Where(o => o.Details.Any(d => d.ProductName == product))
            .OrderBy(o => o.Total);
        //按客户查询
        public IEnumerable<Order> QueryByClient(Client client) =>
            orders.Where(o => o.client.Equals(client))
            .OrderBy(o => o.Total);
        //按订单金额范围查询
        public IEnumerable<Order> QueryByAmount(decimal min, decimal max) =>
            orders.Where(o => o.Total >= min && o.Total <= max)
            .OrderBy(o => o.Total);
        //默认排序
        public void Sort() => orders.Sort((a, b) => a.orderNumber.CompareTo(b.orderNumber));
        //自定义排序
        public void Sort(Comparison<Order> comparsion) => orders.Sort(comparsion);
    }
}
