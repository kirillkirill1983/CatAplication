using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatHelp.Models
{
    public class Medicoment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Options { get; set; }
        public Cat Cat { get; set; }
    }
}
