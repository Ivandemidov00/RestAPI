using Microsoft.EntityFrameworkCore;
using storeRestAPI.Model;

namespace storeRestAPI.Context
{
    public class storeContext:DbContext,IstoreContext
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
        }
    }
}
