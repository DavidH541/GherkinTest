using System;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    [Binding]
    public class SpecFlowFeature3CashWithdrawalSteps
    {
        [Given(@"I have deposited \$(.*) in my account")]
        public void GivenIHaveDepositedInMyAccount(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I request \$(.*)")]
        public void WhenIRequest(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
