using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_Passanger
{
    public static  class PassengerGenerator
    {
        private static int _count = 0;

        public static Passenger CreatePassanger()
        {
            string destination = "jaipur";
            return new Passenger($"Person {++_count}", destination);

        }

    }
}
