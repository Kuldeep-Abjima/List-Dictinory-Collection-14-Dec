using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoute_List
{
    public class BusRouteReposatory
    {
        public static List<BusRoute> IntializeRoute()
        {
            List<BusRoute> Result = new List<BusRoute>
            {
                new BusRoute(40, new string[] { "jaipur", "dudu", "kishangarh", "ajmer" }),
                new BusRoute(41, new string[] { "jaipur", "gujrat", "pune", "goa" }),
                new BusRoute(42, new string[] { "alwar", "jodhpur", "bikaner" }),
                new BusRoute(43, new string[] { "alwar", "jaipur", "ajmer", "agra" })
            };
            return Result;

        }
    }
}