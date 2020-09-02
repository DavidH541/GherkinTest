using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest
{
    class Account
    {
        int balance;

        public void credit(int amount)
        {
            this.balance += amount;
        }
        public void debit(int amount)
        {
            this.balance -= amount;
        }
        public int getBalance()
        {
            return this.balance;
        }
    }
}
