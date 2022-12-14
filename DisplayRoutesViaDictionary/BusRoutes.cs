using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutesViaDictionary
{
    public class BusRoutes
    { 
        public int Number { get; }
        public string Origin => PlaceServed[0];
        public string Destination => PlaceServed[^1];

        public string[] PlaceServed { get; }
        public BusRoutes(int number, string[] placeServed)
        {
            this.Number = number;
            this.PlaceServed = placeServed;

        }
        public override string ToString()
        {
            return $"{Number}: {Origin} -> {Destination}";
        }
    }
}
