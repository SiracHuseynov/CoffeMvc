using CoffeeMVC.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMVC.Data.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; } 
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
