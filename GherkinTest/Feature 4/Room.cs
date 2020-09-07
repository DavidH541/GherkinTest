using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_4
{
    class Room
    {
        public bool available = true;
        public int amountBooked;

        public string book()
        {
            if (!available)
            {
                return "This room is not available!";
            }
            else
            {
                available = false;
                amountBooked++;
                return "Booked this room!";
            }
        }
    }
}
