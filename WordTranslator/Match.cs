using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTranslator
{
    public class Match
    {
        public string id { get; set; }
        public string segment { get; set; }
        public string translation { get; set; }
        public string quality { get; set; }
        public string reference { get; set; }
        [JsonProperty(PropertyName="usage-count")]
        public int usagecount { get; set; }
        public string subject { get; set; }
        [JsonProperty(PropertyName="created-by")]
        public string createdby { get; set; }
        [JsonProperty(PropertyName="last-updated-by")]
        public string lastupdatedby { get; set; }
        [JsonProperty(PropertyName="create-date")]
        public DateTime createdate { get; set; }
        [JsonProperty(PropertyName="last-update-date")]
        public DateTime lastupdatedate { get; set; }
        public double match { get; set; }
    }
}
