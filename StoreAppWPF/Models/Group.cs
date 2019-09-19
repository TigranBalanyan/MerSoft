using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace StoreAppWPF.Models
{
    public class Group : BindableBase
    {
        public string Name { get; set; }
        public string No { get; set; }
        public string Colour { get; set; }

        public Group(string name, string no, string colour)
        {
            Name = name;
            No = no;
            Colour = colour;
        }
    }
}
