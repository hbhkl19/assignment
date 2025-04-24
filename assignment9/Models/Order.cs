namespace assignment9.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
