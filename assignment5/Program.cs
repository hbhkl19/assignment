using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{

    class MainClass
    {
        public static void Main()
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Product milk = new Product(1, "Milk", 69.9f);
            Product eggs = new Product(2, "eggs", 4.99f);
            Product apple = new Product(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1, new DateTime(2021, 3, 21));
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            //order1.AddDetails(new OrderDetail(eggs, 8));
            //order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order()
            {
                Id = 2,
                Customer = customer2,
                CreateTime = new DateTime(2021, 3, 21),
                Details = { new OrderDetail(eggs, 10), new OrderDetail(milk, 10) }
            };

            Order order3 = new Order(3, customer2, new DateTime(2021, 3, 21));
            order3.AddDetails(new OrderDetail(milk, 100));

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            Console.WriteLine("\n GetOrder");
            Console.WriteLine(orderService.GetOrder(1));
            Console.WriteLine(orderService.GetOrder(5) == null);

            Console.WriteLine("\nGetAllOrders");
            List<Order> orders = orderService.QueryAll();
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersByCustomerName:'Customer2'");
            orders = orderService.QueryByCustomerName("Customer2");
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersByProductName:'eggs'");
            orders = orderService.QueryByProductName("eggs");
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersTotalAmount:1000");
            orders = orderService.QueryByTotalPrice(1000);
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nQueryByCondition");
            var query = orderService.Query(o => o.TotalPrice > 1000);
            foreach (Order order in query)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine("\nRemove order(id=2) and qurey all");
            orderService.RemoveOrder(2);
            orderService.QueryAll().ForEach(
                o => Console.WriteLine(o));

            Console.WriteLine("\n order by Amount");
            orderService.Sort(
              (o1, o2) => o2.TotalPrice.CompareTo(o1.TotalPrice));
            orderService.QueryAll().ForEach(
                o => Console.WriteLine(o));

        }
    }
}
