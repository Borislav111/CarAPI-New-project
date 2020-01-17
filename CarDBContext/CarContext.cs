using CarAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.CarDBContext
{
    public class CarContext:DbContext
    {
        public CarContext(DbContextOptions options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
    }

    
}
