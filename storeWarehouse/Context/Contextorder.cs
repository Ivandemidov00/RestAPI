using Microsoft.EntityFrameworkCore;
using storeWarehouse.Model;

namespace storeWarehouse.Context
{
    public class Contextorder:DbContext
    {
        public DbSet<order> orders { get; set; }

        public void MarkAsModifiedOrder(order item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
