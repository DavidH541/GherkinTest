using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_5
{
    class Reservation
    {
        public Reservation(int whitelabelId, int hotelId, int reservationId, int otaId, string externalId, DateTime bookDate)
        {
            WhitelabelId = whitelabelId;
            HotelId = hotelId;
            ReservationId = reservationId;
            OtaId = otaId;
            ExternalId = externalId;
            BookDate = bookDate;
        }
        public int WhitelabelId { get; }
        public int HotelId { get; }
        public int ReservationId { get; }
        public int OtaId { get; }
        public string OtaCode { get; }
        public string ExternalId { get; }
        public DateTime BookDate { get; }
    }
}
