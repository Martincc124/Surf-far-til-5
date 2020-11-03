using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Surfapplikation.Models
{
    public class Properties
    {
        public Meta meta { get; set; }
        public List<Timesery> timeseries { get; set; }
    }
}
