using StrategyApp.Common;
using StrategyApp.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    class AppDemo : App
    {
        protected override int TransactionProcessNumber { get; } = 1;

        protected override void Implementation()
        {
            //Apply(new TakeTwoOffer(new GetOneFree() ) );
            //Apply(new TakeTwoOffer(new FixedDeduction(new Money(7, new Currency("USD")))));
            //Apply(new TakeTwoOffer(new FixDeductionWithSpillover(new Money(12, new Currency("USD")))));

            Apply(new TakeTwoOffer(new GetSecondFree()));
            Apply(new TakeTwoOffer(
                new FromSecondWithSpillover(
                    new Absolute(
                        new Money(
                            12, 
                            new Currency("USD")
                            )
                        )
                    )
                )
                );
            Apply(new TakeTwoOffer(
                new FromSecondWithSpillover(
                    new RelativeToTotal(0.1M)
                    )
                )
                );
            Apply(new TakeTwoOffer(
                new FromSecondWithSpillover(
                    new RelativeToTotal(0.25M)
                    )
                )
                );
            Apply(new TakeTwoOffer(
                new Proportional(
                    new Absolute(
                        new Money(
                            12,
                            new Currency("USD")
                            )
                        )
                    )
                )
                );
        }

        private void Apply(TakeTwoOffer offer) {
            var libro = new Libro("Libro de Patrones", new Money(35, new Currency("USD")));

            var libroCSharp = new Libro("Libro de NET", new Money(10, new Currency("USD")));

            var shoppingCart = offer.ApplyTo(libro, libroCSharp);

            Console.WriteLine();
            Console.WriteLine(shoppingCart.first);

            Console.WriteLine();
            Console.WriteLine(shoppingCart.second);
        }
    }
}
