using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Surfapplikation.Models
{
    public class Root
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }
}
