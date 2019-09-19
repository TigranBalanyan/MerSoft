using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class Product
    {
        public Product(int id, string name, Group group, double price)
        {
            Id = id;
            Name = name;
            Group = group;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public double Price { get; set; }
    }
}
