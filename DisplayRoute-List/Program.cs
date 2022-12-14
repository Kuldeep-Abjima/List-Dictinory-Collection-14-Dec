using DisplayRoute_List;
using System;

namespace DisplayRouteList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BusRoute> allroutes = BusRouteReposatory.IntializeRoute();
            
            Console.WriteLine($"there are {allroutes.Count} number of routs");
            foreach(BusRoute route in allroutes)
            {
                Console.WriteLine($"Route {route}");
            }

            //allroutes.RemoveAt(2); remove one Item in list
            allroutes.RemoveAll(route => route.Origin.StartsWith("jaipur"));
            Console.WriteLine($"there are {allroutes.Count} number of routs");
            foreach (BusRoute route in allroutes)
            {
                Console.WriteLine($"Route {route}");
            }
        }
    }
}
