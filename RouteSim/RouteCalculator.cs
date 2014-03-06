using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GMap7.RouteSim
{
    class RouteCalculator
    {
        public Route calculate(List<PointLatLng> points, int maxSpeed)
        {
            Route myRoute = new Route(maxSpeed);
            myRoute.sections = new List<Section>();
            PointLatLng[] myRouteArray = points.ToArray();
            for (int i = 0; i < myRouteArray.Length - 1; i++)
            {
                Start st = new Start { lat = myRouteArray[i].Lat, lng = myRouteArray[i].Lng };
                Stop sp = new Stop { lat = myRouteArray[i + 1].Lat, lng = myRouteArray[i + 1].Lng };
                myRoute.sections.Add(new Section { start = st, stop = sp });
            }
            return myRoute;
        }
    }
}
