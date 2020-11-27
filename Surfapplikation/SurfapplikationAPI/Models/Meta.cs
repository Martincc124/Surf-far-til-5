using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfapplikationAPI.Models
{
    public class Meta
    {
        public int cost { get; set; }
        public int dailyQuota { get; set; }
        public string end { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public List<string> @params { get; set; }
        public int requestCount { get; set; }
        public string start { get; set; }
    }
}
