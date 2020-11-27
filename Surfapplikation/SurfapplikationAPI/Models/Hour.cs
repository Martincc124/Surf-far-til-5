using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfapplikationAPI.Models
{
    public class Hour
    {
        public AirTemperature airTemperature { get; set; }
        public CloudCover cloudCover { get; set; }
        public DateTime time { get; set; }
        public WaterTemperature waterTemperature { get; set; }
    }
}
