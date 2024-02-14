using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Modifiers
{
    public class GetOneFree : IPrecioModifier
    {
        public (Money first, Money second) ApplyTo(Money a, Money b) => 
            (a , b.Currency.Zero);
    }
}
