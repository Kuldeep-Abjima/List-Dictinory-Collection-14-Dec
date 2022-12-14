using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoute_List
{
    public class BusRoute
    {
        public int Number { get; }
        public string Origin => PlaceServed[0];
        public string Destination => PlaceServed[^1];

        public string[] PlaceServed { get; }
        public BusRoute(int number, string[] placeServed)
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
