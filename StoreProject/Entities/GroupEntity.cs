using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Entities
{
    public class GroupEntity 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //attribute makes the Message Id auto generated in Db
        public int Id { get; set; }

        public string No { get; set; }

        public string Name { get; set; }

        public string Colour { get; set; }

        public GroupEntity(string name, string colour, string no)
        {
            Name = name;
            Colour = colour;
            No = no;
        }

        public GroupEntity(int id, string name, string colour, string no)
        {
            Id = id;
            Name = name;
            Colour = colour;
            No = no;
        }
    }
}
