using System;
using GherkinTest.Feature_5;
using RestSharp;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    [Binding]
    public class SpecFlowFeature5ResponseInDBSteps
    {
        [Given(@"there is a hotel with hotelID (.*)")]
        public void GivenThereIsAHotelWithHotelID(string p0)
        {
        }
        
        [When(@"there is a reservation with ExternalID(.*)")]
        public void WhenThereIsAReservationWithExternalID(string p0)
        {
            // push to basher to invoke request for ota 'exp'
        }
        
        [Then(@"I expect a response in the DB")]
        public void ThenIExpectAResponseInTheDB()
        {
            // do the verification call
            GetReservationsFromBasher();
        }

        private void GetReservationsFromBasher()
        {
            var baseurl = "https://acceptance.smarthotel.nl/basher/api/";
            baseurl = "https://basherweb20200903162540.azurewebsites.net/api/";
            IRestClient client = new RestClient(baseurl);

            IRestRequest request = new RestRequest("/api/reservations", Method.GET, DataFormat.Json);
            request.AddParameter("hotelid", 42075, ParameterType.QueryString);
            request.AddParameter("whitelabelid", 1020, ParameterType.QueryString);

            IRestResponse response = client.Get(request);

            var statuscode = response.StatusCode;
            var content = response.Content;
        }
    }
}
