using System;

namespace RepasoPersona.Core
{
    public abstract class EnteMonetario
    {
        public protected double monto {get; private set; }
        public EnteMonetario (double monto)
        {
            Monto = monto;
        }

        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Efectivo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Efectivo -= monto;
        }
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Efectivo += monto;
        }
    }
}