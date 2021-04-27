using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeRestAPI.Model
{
    public class order
    {
        public Int16 id { get; set; }
        public Int16 idProduct { get; set; }
        public Int16 idUser { get; set; }
        public Int16 amount { get; set; }
        public Decimal price { get; set; }
        public DateTime dateTime { get; set; }
    }
}
