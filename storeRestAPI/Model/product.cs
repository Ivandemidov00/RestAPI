using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeRestAPI.Model
{
    public class product
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Int16 AmountAvailability { get; set; }
        [JsonIgnore]
        public List<order> orders { get; set; }

    }
}
