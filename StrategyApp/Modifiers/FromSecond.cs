using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Modifiers
{
    public class FromSecond : CalculatingModifier
    {
        public FromSecond(IDeduction deduction) : base(deduction)
        {
        }

        protected override (Money first, Money second) ApplyTo(Money a, Money b, Money deduction) =>
            (a, b >= deduction ? b - deduction : b.Currency.Zero);
    }
}
