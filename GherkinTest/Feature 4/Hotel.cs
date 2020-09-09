using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_4
{
    public class Hotel
    {
        public Room[] Rooms = new Room[0];
        public int hotelID { get; }

        public Hotel(int hotelID)
        {
            this.hotelID = hotelID;
        }

        public static void BuildHotel(int hotelID)
        {
            Hotel hotel = new Hotel(hotelID);
            Room kingRoom1 = new KingRoom();
            Room kingRoom2 = new KingRoom();
            Room twinRoom1 = new TwinRoom();
            Room twinRoom2 = new TwinRoom();
            hotel.addRoom(kingRoom1);
            hotel.addRoom(kingRoom2);
            hotel.addRoom(twinRoom1);
            hotel.addRoom(twinRoom2);            
        }


        public void bookRooms(int rooms, Room typeRoom)
        {
            while (rooms > 0)
            {
                int x = 0;
                for (int j = 0; j < Rooms.Length; j++)
                {
                    if (Rooms[j].GetType().Equals(typeRoom.GetType()) && Rooms[j].available)
                    {
                        x = j;
                    }
                }
                Rooms[x].book();
                rooms--;
            }
        }
      

        public void addRoom(Room room)
        {
            Room[] RoomsTemp = new Room[Rooms.Length + 1];
            for (int i = 0; i < RoomsTemp.Length - 1; i++)
            {
                RoomsTemp[i] = Rooms[i];
            }
            RoomsTemp[RoomsTemp.Length - 1] = room;
            Rooms = RoomsTemp;
        }


        public int availableRooms()
        {
            int x = 0;
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i].available)
                {
                    x++;
                }
            }
            return x;
        }

        public int availableRooms(Room typeRoom)
        {
            int x = 0;
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i].GetType().Equals(typeRoom.GetType()) && Rooms[i].available)
                {
                    x++;
                }
            }
            return x;
        }
    }
}
