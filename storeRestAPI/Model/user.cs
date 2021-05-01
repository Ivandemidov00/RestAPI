using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace storeRestAPI.Model
{
    public class user
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        [JsonIgnore]
        public List<order> orders { get; set; }

    }
}
