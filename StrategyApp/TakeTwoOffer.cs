using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    public class TakeTwoOffer
    {
        private Libro? First { get; }
        private Libro? Second { get; }

        //private Func<Money, Money> Modify { get; }
        private IPrecioModifier Modifier { get; }
        public TakeTwoOffer(IPrecioModifier modifier)
        {
            Modifier = modifier;
        }
        /*public (Libro first, Libro second) Apply() => (
            First!.WithPrecioFinal( First!.Precio!.SubtractAmount(7) ), 
            Second!
            );*/
        //public (Libro first, Libro second) Apply() => ReducirPrecioAlBarato(7);
        public (Libro first, Libro second) ApplyTo( Libro first, Libro second ) => 
            ReducirPrecioAlBarato( first, second );

        private (Libro? caro, Libro? barato) Sort(Libro first, Libro second) =>
            first!.Precio! >= second!.Precio! ? (first, second) : (second, first);

        /*private (Libro first, Libro second) ReducirPrecioAlBarato(decimal amount) { 
            var libros = Sort();
            return (libros.caro!, libros!.barato!.WithPrecioFinal( libros!.barato!.Precio!.SubtractAmount(amount) ) );
        }*/
        private (Libro first, Libro second) ReducirPrecioAlBarato( Libro first, Libro second )
        {
            var libros = Sort( first, second );
            var precios = Modifier.ApplyTo(libros.caro!.Precio!, libros.barato!.Precio!);
            return (
                libros.caro!.WithPrecioFinal( precios.first ), 
                libros!.barato!.WithPrecioFinal( precios .second )
            );
        }
    }
}
