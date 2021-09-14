using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatHelp.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Old { get; set; }
        public List<Medicoment> medicoments { get; set; }
    }
}
