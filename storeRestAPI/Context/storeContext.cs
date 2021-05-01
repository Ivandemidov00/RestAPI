using Microsoft.EntityFrameworkCore;
using storeRestAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeRestAPI.Context
{
    public class storeContext:DbContext
    {
        public DbSet<user> users { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<order> orders { get; set; }
        public storeContext(DbContextOptions<storeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<order>().HasOne(r => r.user).WithMany(y => y.orders);
            modelBuilder.Entity<order>().HasOne(r => r.product).WithMany(y => y.orders);
            //modelBuilder.Entity<posts>().HasOne(e => e.categories).WithMany(c => c.posts);
            //modelBuilder.Entity<posts>().HasOne(y => y.user).WithMany(r => r.posts);
        }
    }
}
