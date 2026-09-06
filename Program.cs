using System;
using DRS.Ejercicio1;
using DRS.Ejercicio2;
using DRS.Ejercicio3;
using DRS.Ejercicio4;
using DRS.Ejercicio5;

namespace DRS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("  GUÍA PRÁCTICA 1: POO Y REUTILIZACIÓN  ");
            Console.WriteLine("=======================================\n");

            // EJERCICIO 1: Abstracción
            Console.WriteLine("--- Ejercicio 1: Abstracción ---");
            CuentaBancaria cuenta = new CuentaBancaria(100);
            cuenta.Depositar(50);
            cuenta.Retirar(30);
            cuenta.Retirar(200);
            Console.WriteLine($"Saldo final: ${cuenta.ObtenerSaldo():F2}\n");

            // EJERCICIO 2: Encapsulación
            Console.WriteLine("--- Ejercicio 2: Encapsulación ---");
            Empleado emp = new Empleado("Josué", 25);
            Console.WriteLine($"Empleado: {emp.Nombre}, Edad: {emp.Edad}");
            emp.Edad = -5;
            Console.WriteLine($"Edad sin cambios: {emp.Edad}\n");

            // EJERCICIO 3: Herencia Simple
            Console.WriteLine("--- Ejercicio 3: Herencia Simple ---");
            Coche miCoche = new Coche();
            miCoche.Arrancar();
            miCoche.Conducir();
            miCoche.Detener();
            Console.WriteLine("\n");

            // EJERCICIO 4: Polimorfismo
            DemostracionEjercicio4.Ejecutar();
            Console.WriteLine("\n");

            // EJERCICIO 5: Herencia Multinivel
            DemostracionEjercicio5.Ejecutar();
            Console.WriteLine();
        }
    }
}