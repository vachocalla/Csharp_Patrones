using StrategyApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    public class Libro
    {
        public string? Titulo { get; }
        public virtual Money? Precio { get; }
        public Money? PrecioFinal { get; }

        public Libro(string titulo, Money precio) : this(titulo, precio, precio) { 
        }
        public Libro(string titulo, Money precio, Money precioFinal)
        {
            if (precio.Currency != precioFinal.Currency)
                throw new ArgumentException();
            Titulo = titulo;
            Precio = precio;
            PrecioFinal = precioFinal;
        }

        public virtual Libro WithPrecioFinal(Money precio) =>
            new Libro(Titulo!, Precio!, precio);

        public override string ToString() => 
            $"{Titulo}{Environment.NewLine} {PrecioToString()}";

        private string PrecioToString() =>
            PrecioFinal == Precio ? $"{PrecioFinal}" : $"{PrecioFinal} Anteriormente el precio fue ({Precio})" ;
    }
}
