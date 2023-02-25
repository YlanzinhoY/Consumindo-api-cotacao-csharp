using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ibid
{
    public partial class Currency
    {
        [JsonProperty("bid")]
        public decimal Bid { get; set; }
    }
}
