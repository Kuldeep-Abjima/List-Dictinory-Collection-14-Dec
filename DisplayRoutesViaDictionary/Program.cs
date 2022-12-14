using DisplayRoutesViaDictionary;
using System;

namespace DisplayRouteList
{
    class Program
    {
        static void Main(string[] args)
        {
            var allroutes = BusRouteRepostaryViaDict.IntializeRoute();

            //printng all routes via dictonary

            foreach(var route in allroutes.Values) {
                Console.WriteLine(route);

            }
            Console.WriteLine("enter the route number you want to find ? ");
            int num = int.Parse(Console.ReadLine());

            bool success = allroutes.ContainsKey(num);

            if(success)
            {
                Console.WriteLine($" Found your route {allroutes[num]}");
            }
            else
            {
                Console.WriteLine($"Not Found your route {num}");
            }
            //Console.WriteLine($"there are {allroutes.Count} number of routs");
            //foreach (BusRoutes route in allroutes)
            //{
            //    Console.WriteLine($"Route {route}");
            //}

            ////allroutes.RemoveAt(2); remove one Item in list
            //allroutes.RemoveAll(route => route.Origin.StartsWith("jaipur"));
            //Console.WriteLine($"there are {allroutes.Count} number of routs");
            //foreach (BusRoutes route in allroutes)
            //{
            //    Console.WriteLine($"Route {route}");
            //}
        }
    }
}
