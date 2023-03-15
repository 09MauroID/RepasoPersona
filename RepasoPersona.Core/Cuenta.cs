using System;

namespace RepasoPersona.Core
{
    public class Cuenta : EnteMonetario
    {
        public int CBU {get; private set;}
        public int Contador {get; private set;}
        public Cuenta(int CBU)
        {
            CBU = cbu;
            Contador = contador;
        }

        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monoto tiene que ser mnayor a cero. ");
            
            if (monto > Efectivo)
                throw new InvalidOperationException("El monto supera al efectivo. ");
            Efectivo -= monto;
        {
            public void Acreditar(double monto)
            {
                if (monto <= 0)
                    throw new ArgumentException("El monto tiene que ser mayor a cero. ");
                    Efectivo += monto;
            }
        }
        }
    }
}