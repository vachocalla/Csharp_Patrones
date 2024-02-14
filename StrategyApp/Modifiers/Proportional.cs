using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Modifiers
{
    public class Proportional : CalculatingModifier
    {
        public Proportional(IDeduction deduction) : base(deduction)
        {
        }

        protected override (Money first, Money second) ApplyTo(Money a, Money b, Money deduction)
        {
            var factor = b / (a + b);
            var bDeductionFull = factor * deduction;
            var bDeduction = b >= bDeductionFull ? bDeductionFull: b;
            var spill = deduction - bDeduction;

            var aDeduction = a >= spill ? spill : a;
            return (a - aDeduction, b - bDeduction);
        }
    }
}
