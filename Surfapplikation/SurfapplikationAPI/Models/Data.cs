using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Surfapplikation.Models
{
    public class Data
    {
        public Instant instant { get; set; }
        public Next12Hours next_12_hours { get; set; }
        public Next1Hours next_1_hours { get; set; }
        public Next6Hours next_6_hours { get; set; }
    }
}
