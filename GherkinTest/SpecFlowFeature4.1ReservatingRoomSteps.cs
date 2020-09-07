using System;
using GherkinTest.Feature_4;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    [Binding]
    public class SpecFlowFeature41ReservatingRoomSteps
    {
        Hotel hotel;

        [Given(@"hotel (.*) exists with KingRooms")]
        public void GivenHotelExistsWithKingRooms(int p0)
        {
            hotel = new Hotel(p0);
            Room kingRoom1 = new KingRoom();
            Room kingRoom2 = new KingRoom();
            Room twinRoom1 = new TwinRoom();
            Room twinRoom2 = new TwinRoom();
            hotel.addRoom(kingRoom1);
            hotel.addRoom(kingRoom2);
            hotel.addRoom(twinRoom1);
            hotel.addRoom(twinRoom2);
        }

        [Given(@"has a KingRoom available")]
        public void GivenHasAKingRoomAvailable()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a KingRoom is booked")]
        public void WhenAKingRoomIsBooked()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"it should return (.*)")]
        public void ThenItShouldReturn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
