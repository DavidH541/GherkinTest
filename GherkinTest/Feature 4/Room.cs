using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_4
{
    class Room
    {
        Hotel hotel;
        string roomType;

        public Room(Hotel hotel, string roomtype)
        {
            this.hotel = hotel;
            this.roomType = roomtype;
        }
    }
}//WIP
