/****
    Ejercicio 4: Polimorfismo

    Objetivo:  Implementar polimorfismo utilizando métodos sobrescritos.

    Enunciado: Crea una clase base Animal con un método HacerSonido(). Luego, crea dos clases derivadas:
               Perro y Gato, que sobrescriban el método HacerSonido() para hacer un sonido diferente.
               Utiliza una referencia de tipo Animal para llamar al método HacerSonido() y demostrar el polimorfismo.

    Instrucciones:
        • Define la clase base Animal con el método HacerSonido().
        • Sobrescribe HacerSonido() en las clases Perro y Gato.
        • Crea instancias de Perro y Gato, y usa una referencia de tipo Animal para llamar al método.

    Codigo hecho por: Salvador Enrique Quezada Campos QC07003
**/

using System;
public class Animal
{
    //La palabra virtual permite que el método sea sobreescrito en las clases derivadas
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}// fin de la clase

// clase derivada Perro, hereda de la clase animal y sobreescribe el método HacerSonido()
public class Perro : Animal
{
    //sobrescribimos el método HacerSonido() de la clase base
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra: GUAU, GUAU");
    }
}//fin clase Perro

// clase derivada Gato, hereda de la clase animal y sobreescribe el metodo HacerSonido()
public class Gato : Animal
{
    //sobrescribimos el método HacerSonido() de la clase base
    public override void HacerSonido()
    {
        Console.WriteLine("El Gato maúlla: MIAU, MIAU");
    }
}// fin clase Gato

//clase que contiene el punto de entrada de la aplicación
class Ejercicio4
{
    static void Main(string[] args)
    {
        //instancia de clases
        Perro perro = new Perro(); // declaramos un objeto llamado perro de tipo Perro
        Gato gato = new Gato(); // declaramos un objeto llamado gato de tipo Gato

        //Asignación polimórfica
        Animal animal1 = perro; //guardamos la instancia de perro en una referencia de tipo Animal
        Animal animal2 = gato; //guardamos la instancia de gato en una referencia de tipo Animal


        Console.WriteLine("********* POLIMORFISMO *********\n");
        Console.WriteLine("Referencias de tipo Animal:");
        animal1.HacerSonido(); // Salida: El perro ladra: GUAU, GUAU
        animal2.HacerSonido(); // Salida: El Gato maúlla: MIAU, MIAU

        Console.WriteLine("\nReferencias directas:");
        perro.HacerSonido(); // Salida: El perro ladra: GUAU, GUAU
        gato.HacerSonido(); // Salida: El Gato maúlla: MIAU, MIAU


    }//fin de Main
}//fin de la clase Ejercicio4
