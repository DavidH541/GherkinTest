using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_4
{
    public class Room
    {
        public bool available = true;
        public int amountBooked;

        public void book()
        {
            if (available)
            {
                available = false;
                amountBooked++;
            }
        }
    }
}
