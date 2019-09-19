using StoreProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Entities
{
    public class ProductEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //attribute makes the Message Id auto generated in Db
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public Group Group { get; set; }

        public double Price { get; set; }

        public ProductEntity(int id, string name, double price, Group group)
        {
            Id = id;
            Name = name;
            Price = price;
            Group = group;
        }

        public ProductEntity(string name, double price, Group group)
        {
            Name = name;
            Price = price;
            Group = group;
        }

        public ProductEntity()
        {
        }

    }
}
