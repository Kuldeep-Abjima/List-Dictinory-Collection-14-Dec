using queue_Passanger;
using System;

namespace queuePassnger
{
    public class program
    {
        static void Main(string[] args)
        {
            BusStop busStop = new BusStop();
            Bus bus = new Bus();

            for(int i = 0; i < 6; i++)
            {
                busStop.PersonArrived(PassengerGenerator.CreatePassanger());
            }
            busStop.BusArrive(bus);
            bus.BusArrivedAtTerminus();
        }
    }
}
