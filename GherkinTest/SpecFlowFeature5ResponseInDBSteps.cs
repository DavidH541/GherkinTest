using System;
using GherkinTest.Feature_5;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    [Binding]
    public class SpecFlowFeature5ResponseInDBSteps
    {
        [Given(@"there is a hotel with hotelID (.*)")]
        public void GivenThereIsAHotelWithHotelID(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"there is a reservation with ExternalID(.*)")]
        public void WhenThereIsAReservationWithExternalID(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I expect a response in the DB")]
        public void ThenIExpectAResponseInTheDB()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
