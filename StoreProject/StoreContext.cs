using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using StoreProject.Entities;
using StoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        //public DbSet<Sale> Sales { get; set; }
    }
}
