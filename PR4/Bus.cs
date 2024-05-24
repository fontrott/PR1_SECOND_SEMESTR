using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    using System;
    using System.Collections.Generic;

    using System;
    using System.Collections.Generic;

    internal class BusInfo
    {
        public int BusNumber { get; set; }
        public string DriverName { get; set; }
        public string RouteNumber { get; set; }
        public bool IsOnRoute { get; set; }

        public BusInfo(int BusNumber, string DriverName, string RouteNumber, bool IsOnRoute)
        {
            this.BusNumber = BusNumber;
            this.DriverName = DriverName;
            this.RouteNumber = RouteNumber;
            this.IsOnRoute = IsOnRoute;
        }
    }
}
