using System;

namespace DRS.Ejercicio3
{
    // Clase base
    public class Vehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("El vehículo ha arrancado.");
        }

        public void Detener()
        {
            Console.WriteLine("El vehículo se ha detenido.");
        }
    }

    // Clase derivada que hereda de Vehiculo
    public class Coche : Vehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("El coche está en marcha (conduciendo).");
        }
    }
}