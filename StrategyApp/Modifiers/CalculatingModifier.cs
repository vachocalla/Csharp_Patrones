using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Modifiers
{
    public abstract class CalculatingModifier : IPrecioModifier
    {
        private IDeduction? Deduction { get; }
        public CalculatingModifier(IDeduction deduction)
        {
            Deduction = deduction;
        }
        public (Money first, Money second) ApplyTo(Money a, Money b) => 
            ApplyTo(a,b,Deduction!.From(a,b));

        protected abstract (Money first, Money second) ApplyTo(Money a, Money b, Money deduction);
    }
}
