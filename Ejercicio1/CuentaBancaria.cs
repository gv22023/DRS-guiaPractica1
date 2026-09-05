using System;

namespace DRS.Ejercicio1
{
    /// <summary>
    /// Clase que representa una cuenta bancaria aplicando el principio de abstracción.
    /// Oculta el atributo privado del saldo y solo permite interactuar mediante métodos públicos.
    /// </summary>
    public class CuentaBancaria
    {
        // Atributo privado para proteger y ocultar el saldo (Abstracción/Encapsulación)
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