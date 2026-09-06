/***
    Ejercicio 3: Herencia Simple 

    Objetivo: Implementar herencia simple para extender las funcionalidades de una clase 
    base.

    Enunciado: 
    Crea una clase base Vehiculo que tenga los métodos Arrancar() y Detener(). Luego, crea una 
    clase derivada Coche que herede de Vehiculo y añada un método Conducir(). Asegúrate de 
    que el Coche pueda usar los métodos heredados de Vehiculo y su propio método 
    Conducir(). 

    Instrucciones: 
        • Define la clase base Vehiculo con los métodos Arrancar() y Detener(). 
        • Define la clase derivada Coche que herede de Vehiculo y añada el método 
        Conducir(). 
        • Crea una instancia de Coche y usa todos los métodos. 

    Código Hecho por: Josué Adán García Valiente
**/

using System;

namespace DRS.Ejercicio3
{
// Clase base vehiculo
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