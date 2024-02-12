using DecoratorApp.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorApp.HappyBirthday
{
    class HappyBirthdayFiesta : AbstractFiesta
    {
        protected override int EventNumber { get; } = 1;

        protected override void Implementation()
        {
            IPastel pastelPack = new PastelPreparado(
                "Cumple de Juan",
                new Size(
                    188 * Length.Millimeter, 
                    239 * Length.Millimeter, 
                    28 * Length.Millimeter)
                );

            IPastel paquetePastel = new PastelPackTotal(pastelPack);


            // DELETED var comprador = new Comprador();
            // DELETED comprador.Handle(pastel);
            var comprador = new PastelHandler();
            comprador.Handle(paquetePastel);


            IPastel wrappedPastel = new WrappedPastel(paquetePastel);

            // DELETED var empleado = new Empleado();
            // DELETED empleado.Handle(pastel);
            var empleado = new PastelHandler();
            empleado.Handle(wrappedPastel);
        }
    }
}
