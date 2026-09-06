/***
    Ejercicio 1: Implementación de Abstracción de Datos 

    Objetivo: Implementar un tipo de datos abstracto que oculta detalles de implementación. 

    Enunciado: 
    Crea una clase CuentaBancaria que represente una cuenta bancaria. Utiliza abstracción de 
    datos para ocultar el detalle de la implementación del saldo y solo permite el acceso a través 
    de los métodos públicos. Los métodos deben permitir realizar operaciones como depositar, 
    retirar y consultar el saldo. 

    Instrucciones: 
        • Define la clase CuentaBancaria con un atributo privado para el saldo. 
        • Implementa los métodos: 
        • Depositar(decimal monto): permite agregar dinero a la cuenta. 
        • Retirar(decimal monto): permite retirar dinero de la cuenta. 
        • ObtenerSaldo(): devuelve el saldo actual. 
        • Los métodos deben validar que los montos sean positivos y que no haya fondos insuficientes para la operación de retiro.

    Codigo hecho por: Josué Adán García Valiente - GV22023

**/

using System;

namespace DRS.Ejercicio1
{
   
    // Clase que representa una cuenta bancaria aplicando el principio de abstracción.
    
    public class CuentaBancaria
    {
        // Atributo privado para proteger y ocultar el saldo 
        private decimal saldo;

        // Constructor
        public CuentaBancaria(decimal saldoInicial = 0)
        {
            if (saldoInicial < 0)
            {
                Console.WriteLine("El saldo inicial no puede ser negativo. Se asignará $0.00.");
                this.saldo = 0;
            }
            else
            {
                this.saldo = saldoInicial;
            }
        }

        // Permite agregar dinero a la cuenta
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a depositar debe ser positivo.");
                return;
            }

            saldo += monto;
            Console.WriteLine($"Depósito exitoso de ${monto:F2}. Saldo actual: ${saldo:F2}");
        }

        // Permite retirar dinero validando fondos suficientes
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a retirar debe ser mayor a cero.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine($"Error: Fondos insuficientes. Saldo disponible: ${saldo:F2}, Intento de retiro: ${monto:F2}");
                return;
            }

            saldo -= monto;
            Console.WriteLine($"Retiro exitoso de ${monto:F2}. Saldo restante: ${saldo:F2}");
        }

        // Devuelve el saldo actual
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
}