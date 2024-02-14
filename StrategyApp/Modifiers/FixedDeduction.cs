using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Modifiers
{
    
    public class FixedDeduction : IPrecioModifier
    {
        private Money Amount { get; }
        public FixedDeduction( Money amount ) { 
            Amount = amount;
        }
        public (Money first, Money second) ApplyTo(Money a, Money b) =>
            b >= Amount ? (a, b-Amount) : (a, b.Currency.Zero);
    }
}
