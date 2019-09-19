using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class Sale
    {
        public string No { get; set; }
        public Group Group { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
