using System;
using DRS.Ejercicio1;
using DRS.Ejercicio2;
using DRS.Ejercicio3;

namespace DRS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 1: CUENTA BANCARIA ===");
            CuentaBancaria cuenta = new CuentaBancaria(100);
            cuenta.Depositar(50);
            cuenta.Retirar(30);
            cuenta.Retirar(200); // Intento de retiro sin fondos
            Console.WriteLine($"Saldo final: ${cuenta.ObtenerSaldo():F2}\n");

            Console.WriteLine("=== EJERCICIO 2: EMPLEADO ===");
            Empleado emp = new Empleado("Josué", 25);
            Console.WriteLine($"Empleado: {emp.Nombre}, Edad: {emp.Edad}");
            emp.Edad = 150; // Intento de asignación de edad fuera de rango
            Console.WriteLine($"Edad tras intento inválido: {emp.Edad}\n");

            Console.WriteLine("=== EJERCICIO 3: COCHE Y HERENCIA ===");
            Coche miCoche = new Coche();
            miCoche.Arrancar();  // Método heredado de Vehiculo
            miCoche.Conducir();   // Método propio de Coche
            miCoche.Detener();   // Método heredado de Vehiculo
        }
    }
}