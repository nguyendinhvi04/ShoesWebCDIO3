using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store_Project.Models;

namespace Store_Project.Data
{
    public class Store_ProjectContext : DbContext
    {
        public Store_ProjectContext (DbContextOptions<Store_ProjectContext> options)
            : base(options)
        {
        }
        public DbSet<Store_Project.Models.Category> Category { get; set; } = default!;
        public DbSet<Store_Project.Models.Product> Product { get; set; } = default!;
        public DbSet<Store_Project.Models.User> User { get; set; } = default!;
        public DbSet<Store_Project.Models.Customer> Customer { get; set; } = default!;
  

        
    }
}
