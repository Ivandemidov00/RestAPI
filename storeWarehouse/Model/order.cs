using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeWarehouse.Model
{
    public class order
    {
        public Int16 Id { get; set; }
        public String name { get; set; }
        public Int16 quantity { get; set; }
        public Int16 idStore { get; set; }
    }
}
