using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeRestAPI.Model
{
    public class order
    {
        public Int16 Id { get; set; }
        public Int16 Amount { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public product product { get; set; }
        public user user { get; set; }
       // public Int16 productId { get; set; }
       // public Int16 userId { get; set; }
    }
}
