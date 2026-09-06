/**
    Ejercicio 2: Encapsulación y Control de Acceso 

    Objetivo: Aplicar la encapsulación para proteger los datos y controlar el acceso a los 
    métodos de una clase. 

    Enunciado: 
    Crea una clase Empleado que tenga dos atributos privados: nombre y edad. Implementa 
    encapsulación para acceder a estos atributos a través de propiedades. Asegúrate de que la 
    edad solo pueda ser modificada a través de un valor válido (mayor que 0 y menor que 100). 

    Instrucciones: 
        • Define la clase Empleado con los atributos privados. 
        • Usa propiedades para controlar el acceso a nombre y edad. 
        • La propiedad de edad debe validar que el valor sea positivo y menor que 100. 

    Codigo hecho por: Josué Adán García Valiente - GV22023
**/

using System;

namespace DRS.Ejercicio2
{
    public class Empleado
    {
        // Atributos privados
        private string nombre;
        private int edad;

        // Constructor
        public Empleado(string nombre, int edad)
        {
            this.nombre = nombre;
            this.Edad = edad; 
        }

        // Propiedad para Nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // Propiedad para Edad y su validación
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0 && value < 100)
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine($"Error: La edad ({value}) no es válida. Debe ser mayor que 0 y menor que 100.");
                }
            }
        }
    }
}