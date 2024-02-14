using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Modifiers
{
    public class Absolute : IDeduction
    {
        private Money? Amount { get; }

        public Absolute( Money amount ) { 
            Amount = amount;
        }
        public Money From(Money a, Money b) =>
            Amount!;
    }
}
