using System;
using System.Collections.Generic;
using System.Text;

namespace LocationMonitoring.Model
{
    public class Location
    {
        public DateTime TimeStamp { get; set; }

        public double? Alt { get; set; }
        public double Lat { get; set; }

        public double Long { get; set; }
    }
}
