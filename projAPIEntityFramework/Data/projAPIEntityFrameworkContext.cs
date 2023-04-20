using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projAPIEntityFramework.Models;

namespace projAPIEntityFramework.Data
{
    public class projAPIEntityFrameworkContext : DbContext
    {
        public projAPIEntityFrameworkContext (DbContextOptions<projAPIEntityFrameworkContext> options)
            : base(options)
        {
        }

        public DbSet<projAPIEntityFramework.Models.Animal> Animal { get; set; } = default!;

        public DbSet<projAPIEntityFramework.Models.Client>? Client { get; set; }

        public DbSet<projAPIEntityFramework.Models.Address> Address { get; set; }
    }
}
