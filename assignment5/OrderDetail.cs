using assignment5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{

    /**
     **/
    public class OrderDetail
    {

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public float TotalPrice
        {
            get => Product.Price * Quantity;
        }

        public OrderDetail() { }

        public OrderDetail(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&
                   EqualityComparer<Product>.Default.Equals(Product, detail.Product);
        }

        public override int GetHashCode()
        {
            return 785010553 + EqualityComparer<Product>.Default.GetHashCode(Product);
        }

        public override string ToString()
        {
            return $"OrderDetail:{Product},{Quantity}";
        }
    }
}
