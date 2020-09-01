using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace GherkinTest
{
    class ATM
    {
        int balance;
    }
    class Account
    {
        int balance;

        public void deposit(int amount)
        {
            this.balance += amount;
        }
        public void withdraw(int amount)
        {
            this.balance -= amount;
        }
        public int getBalance()
        {
            return this.balance;
        }
    }

    [Binding]
    public class SpecFlowFeature3CashWithdrawalSteps
    {

        [Given(@"I have deposited \$(.*) in my account")]
        public void GivenIHaveDepositedInMyAccount(int p0)
        {
            Account my_account = new Account();
            my_account.deposit(p0);
            my_account.getBalance().Should().Be(p0);
        }
        
        [When(@"I request \$(.*)")]
        public void WhenIRequest(int p0)
        {
            ATM 
        }

        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
