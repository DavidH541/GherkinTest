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
}
