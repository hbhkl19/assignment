using System;

namespace assignment5
{

    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public Product() { }

        public Product(int id, string name, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public override bool Equals(object obj)
        {
            var product = obj as Product;
            return product != null && Id == product.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Value:{Price}";
        }

    }
}