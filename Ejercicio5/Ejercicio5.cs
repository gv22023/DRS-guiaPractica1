/**

Ejercicio 5: Herencia Multinivel y Sobrescritura de Métodos

Objetivo: Demostrar herencia multinivel y sobrescritura de métodos.

Enunciado:
Crea una jerarquía de clases en la que Animal sea la clase base, Mamifero sea una clase
intermedia y Perro sea una clase derivada. Asegúrate de que Perro herede los métodos de
Mamifero y Animal, y sobrescriba el método HacerSonido().

Instrucciones:
    • Define la clase base Animal con un método HacerSonido().
    • Define la clase intermedia Mamifero que herede de Animal y añada un método Alimentar().
    • Define la clase Perro que herede de Mamifero y sobrescriba HacerSonido().
    • Crea instancias y demuestra la llamada a los métodos heredados y sobrescritos.

código creado por Salvador Enrique Quezada Campos QC07003
*/

using System;

//Clase base Animal que tendra el método HacerSonido()
public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }

    public void Respirar()
    {
        Console.WriteLine("El animal está respirando");
    }
}//fin de la clase Animal

// clase intermedia Mamifero que hereda de Animal y añade el método Alimentar()
public class Mamifero : Animal
{
    //Método Alimentar que es exclusivo de la clase
    public void Alimentar()
    {
        Console.WriteLine("El mamífero se alimenta");
    }
}// fin de la clase Mamifero

// Clase derivada perro que hereda de mamifero y sobreescribe HacerSonido()
public class Perro : Mamifero
{
    //se sobreescribe el método HacerSonido()
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra: GUAU, GUAU");
    }

    public void Correr()
    {
        Console.WriteLine("El perro está corriendo");
    }
}// fin clase Perro

//Clase principal
class Ejercicio5
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** Herencia Multinivel y Sobrescritura ******\n");

        // Creamos la instancia de la clase
        Perro miPerro = new Perro();

        Console.WriteLine("****** Métodos disponibles en Perro ******");
        miPerro.HacerSonido();  // Sobrescrito
        miPerro.Respirar();     // Heredado de Animal
        miPerro.Alimentar();    // Heredado de Mamifero
        miPerro.Correr();       // Propio
        
        Console.WriteLine("\n****** Polimorfismo con referencias de diferentes niveles ******");
        
        Animal animalRef = miPerro;
        Mamifero mamiferoRef = miPerro;
        Perro perroRef = miPerro;
        
        Console.Write("Desde Animal: ");
        animalRef.HacerSonido();
        
        Console.Write("Desde Mamifero: ");
        mamiferoRef.HacerSonido();
        
        Console.Write("Desde Perro: ");
        perroRef.HacerSonido();
    }// fin de Main
}// fin de la clase Ejercicio5

