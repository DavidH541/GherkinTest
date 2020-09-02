using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace GherkinTest
{
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
    class ATM
    {
        CashSlot cashSlot;

        public ATM(CashSlot cashSlot1) 
        { 
            this.cashSlot = cashSlot1; 
        }
        public void withdraw_from(Account account, int amount)
        {
            account.withdraw(amount);
            cashSlot.setContents(amount);
        }
    }  
    class CashSlot
    {
        int contents;
             
        public void setContents(int amount)
        {
            this.contents = amount;
        }
        public int getContents()
        {
            return this.contents;
        }
    }

    [Binding]
    public class SpecFlowFeature3CashWithdrawalSteps
    {
        Account my_account = new Account();
        static CashSlot cash_slot = new CashSlot();
        ATM my_atm = new ATM(cash_slot);


        [Given(@"I have deposited \$(.*) in my account")]
        public void GivenIHaveDepositedInMyAccount(int p0)
        {           
            my_account.deposit(p0);
            my_account.getBalance().Should().Be(p0);
        }
        
        [When(@"I withdraw \$(.*)")]
        public void WhenIwithdraw(int p0)
        {           
            my_account.getBalance().Should().BeGreaterOrEqualTo(p0);
            my_atm.withdraw_from(my_account, p0);            
        }

        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int p0)
        {
            cash_slot.getContents().Should().Be(p0);
        }
    }
}
