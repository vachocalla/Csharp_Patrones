using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Modifiers
{
    public class FixDeductionWithSpillover : IPrecioModifier
    {
        private Money? Amount { get; }
        public FixDeductionWithSpillover(Money? amount)
        {
            Amount = amount;
        }

        public (Money first, Money second) ApplyTo(Money a, Money b)
        {
            var deduct = b >= Amount! ? Amount : b;
            var spill = Amount! - deduct!;
            var deductSpill = a >= spill ? spill : a;
            return (a - deductSpill, b - deduct!);
        }
    }
}
