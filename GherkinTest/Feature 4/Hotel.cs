using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_4
{
    class Hotel
    {
        public int hotelID { get; }
        public int availableRooms { get; }

        public Hotel(int hotelID, int availablerooms1)
        {
            this.hotelID = hotelID;
            this.availableRooms = availablerooms1;
        }
    }
}
