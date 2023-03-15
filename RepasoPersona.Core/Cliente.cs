|using System;

namespace RepasoPersona.Core
{
    public class Cliente : EnteMonetario
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public double Efectivo { get; private set; }
        public Cliente() => Efectivo = 0;
        public Cliente(string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Efectivo = efectivo;
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
