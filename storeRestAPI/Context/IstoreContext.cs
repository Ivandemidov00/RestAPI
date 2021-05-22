using Microsoft.EntityFrameworkCore;
using storeRestAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeRestAPI.Context
{
    public interface IstoreContext
    {
        DbSet<user> users { get; set; } 
        DbSet<product> products { get; set; }
        DbSet<order> orders { get; set; }
        int SaveChanges();
        void MarkAsModifiedProduct(product item);
        void MarkAsModifiedUser(user item);
        void MarkAsModifiedOrder(order item);
    }
}
