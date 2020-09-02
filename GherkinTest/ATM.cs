using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest
{
    class ATM
    {
        CashSlot cashSlot;

        public ATM(CashSlot cashSlot1)
        {
            this.cashSlot = cashSlot1;
        }
        public void withdraw_from(Account account, int amount)
        {
            if (account.getBalance() >= amount)
            {
                account.withdraw(amount);
                cashSlot.setContents(amount);
            }
        }
    }
}
