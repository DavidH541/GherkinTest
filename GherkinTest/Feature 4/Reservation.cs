using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_4
{
    class Reservation
    {
        string ExtID;
        Hotel hotel;
        int amountOfRooms;
        bool passed = false;

        public Reservation(string extID, Hotel hotel1, int amountOfRooms1)
        {
            if (hotel1.availableRooms >= amountOfRooms1)
            {
                this.ExtID = extID;
                this.hotel = hotel1;
                this.amountOfRooms = amountOfRooms1;
                this.passed = true;
            } 
        }
        
        public string Passed()
        {
            if (this.passed)
                return "The reservation has passed!" + " " + hotel.hotelID + " " + ExtID;
            else
                return "The reservation has not passed!";
        }
    }
}
