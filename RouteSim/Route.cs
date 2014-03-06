using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap7.RouteSim
{
    class Route
    {
        public Route()
        {

        }

        public Route(Dictionary<String, String> details)
        {
            this.details = details;
        }

        public Dictionary<String, String> details { get; set; }
        public List<Section> sections { get; set; }
    }

    class Section
    {
        public int maxSpeed { get; set; }
        public Start start { get; set; }
        public Stop stop { get; set; }
    }

    class Start
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    class Stop
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }
}
