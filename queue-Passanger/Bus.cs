using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_Passanger
{
    public  class Bus
    {
        public const int Capacity = 5;

        public int  Space { get => Capacity - _passenger.Count; }
        private Stack<Passenger> _passenger = new Stack<Passenger>(); 

        public bool Load(Passenger passenger)
        {
            if (Space < 1) {
                return false;
            }
            _passenger.Push(passenger);
            Console.WriteLine($"{passenger} got into the bus");
            return true;
        }
        public void BusArrivedAtTerminus(){
            Console.WriteLine($"\r\n Bus Arriving At terminus");
            while(_passenger.Count > 0)
            {
                Passenger passenger= _passenger.Pop();
                Console.WriteLine($"{passenger} got off the bus");
            }
            Console.WriteLine($"there are {_passenger.Count} are still on bus");
        }
    }
}
