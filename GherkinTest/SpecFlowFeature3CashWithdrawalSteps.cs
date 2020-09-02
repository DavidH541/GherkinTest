using System;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    [Binding]
    public class SpecFlowFeature3CashWithdrawalSteps
    {
        Account my_account = new Account();
        static CashSlot cash_slot = new CashSlot();
        ATM my_atm = new ATM(cash_slot);

        [Given(@"my account has been credited with \$(.*)")]
        public void GivenMyAccountHasBeenCreditedWith(int p0)
        {
            my_account.credit(p0);
        }

        [When(@"I withdraw \$(.*)")]
        public void WhenIWithdraw(int p0)
        {
            my_atm.withdraw_from(my_account, p0);
        }

        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int p0)
        {
            cash_slot.getContents().Should().Be(p0);
        }

        [Then(@"the balance of my account should be \$(.*)")]
        public void ThenTheBalanceOfMyAccountShouldBe(int p0)
        {
            my_account.getBalance().Should().Be(p0);
        }
    }
}
