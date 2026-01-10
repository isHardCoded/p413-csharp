using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Name}, {Price}, {Stock}";
        }
    }

    class Electronics : Product
    {
        public string Brand { get; set; }
        public int WarrantyMonths { get; set; }

        public Electronics(int id, string name, decimal price, int stock, string brand, int warrantyMonths) : base(id, name, price, stock)
        {
            Brand = brand;
            WarrantyMonths = warrantyMonths;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Brand}, {WarrantyMonths}";
        }
    }

    class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public Clothing(int id, string name, decimal price, int stock, string size, string material) : base(id, name, price, stock)
        {
            Size = size;
            Material = material;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Size}, {Material}";
        }
    }
}
