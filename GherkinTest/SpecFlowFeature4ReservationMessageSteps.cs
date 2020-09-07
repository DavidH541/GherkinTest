using FluentAssertions;
using GherkinTest.Feature_4;
using System;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    [Binding]
    public class SpecFlowFeature4ReservationMessageSteps
    {
        Hotel hotel;
        string passed;

        [Given(@"hotel (.*) has available rooms")]
        public void GivenHotelHasAvailableRooms(int p0)
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
            hotel.availableRooms().Should().BeGreaterThan(0);
            hotel.availableRooms().Should().Be(4);
        }

        [When(@"a new reservation (.*) is made with (.*) KingRooms and (.*) TwinRooms")]
        public void WhenANewReservationIsMadeWithKingRoomsAndTwinRooms(string p0, int p1, int p2)
        {
            Reservation reservation = new Reservation(p0, hotel, p1, p2);
            passed = reservation.Passed();
        }

        [Then(@"I should recieve a message (.*)")]
        public void ThenIShouldRecieveAMessage(string p0)
        {
            passed.Should().Be(p0);
        }
    }
}
