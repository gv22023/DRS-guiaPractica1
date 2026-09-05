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