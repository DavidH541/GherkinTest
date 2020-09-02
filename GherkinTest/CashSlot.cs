using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest
{
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
}
