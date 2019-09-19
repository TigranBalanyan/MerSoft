using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }

        public Group(int id, string name, string no, string colour)
        {
            Id = id;
            Name = name;
            No = no;
            Colour = colour;
        }
    }
}
