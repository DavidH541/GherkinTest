using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_4
{
    public class Reservation
    {
        string ExtID;
        Hotel hotel;
        bool passed = false;

        public Reservation(string extID, Hotel hotel, int KingRooms, int TwinRooms)
        {
            this.ExtID = extID;
            this.hotel = hotel;

            if (hotel.availableRooms(new KingRoom()) >= KingRooms
             && hotel.availableRooms(new TwinRoom()) >= TwinRooms)
            {                
                this.passed = true;
                hotel.bookRooms(KingRooms, new KingRoom());
                hotel.bookRooms(TwinRooms, new TwinRoom());
            }
        }

        public string Passed()
        {
            if (this.passed)
                return "The reservation has passed!" + " " + hotel.hotelID + " " + ExtID;
            else
                return "The reservation has not passed!" + " " + hotel.hotelID + " " + ExtID;
        }
    }
}
