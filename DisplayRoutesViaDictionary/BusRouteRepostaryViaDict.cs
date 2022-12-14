using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutesViaDictionary
{
    public class BusRouteRepostaryViaDict
    {
        public static SortedDictionary<int, BusRoutes> IntializeRoute()
        {
            BusRoutes Route42 = new BusRoutes(42, new string[] { "jaipur", "dudu", "kishangarh", "ajmer" });
             BusRoutes Route41 = new BusRoutes(41, new string[] { "jaipur", "gujrat", "pune", "goa" });
            BusRoutes Route40 = new BusRoutes(40, new string[] { "alwar", "jodhpur", "bikaner" });
            BusRoutes Route43 = new BusRoutes(43, new string[] { "alwar", "jaipur", "ajmer", "agra" });


            var Routes = new SortedDictionary<int, BusRoutes>
            {
                { 42, Route42 },
                { 41, Route41 },
                { 40, Route40 },
                { 43, Route43 }
            };
            return Routes;


        }
    }
}
