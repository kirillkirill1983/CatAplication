using CatHelp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatHelp.Date
{
    public class CatContext:DbContext
    {
        public CatContext(DbContextOptions<CatContext> opt) : base(opt)
        {

        }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Medicoment> Medicoments { get; set; }
    }
}
