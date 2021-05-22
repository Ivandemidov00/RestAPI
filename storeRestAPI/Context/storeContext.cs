using Microsoft.EntityFrameworkCore;
using Model;
using storeRestAPI.Model;

namespace storeRestAPI.Context
{
    public class storeContext:DbContext,IstoreContext
    {
        public DbSet<user> users { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<ordercheck> orderchecks { get; set; }
        public storeContext(DbContextOptions<storeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<order>().HasOne(r => r.user).WithMany(y => y.orders);
            modelBuilder.Entity<order>().HasOne(r => r.product).WithMany(y => y.orders);
        }

        public void MarkAsModifiedProduct(product item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModifiedUser(user item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModifiedOrder(order item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
