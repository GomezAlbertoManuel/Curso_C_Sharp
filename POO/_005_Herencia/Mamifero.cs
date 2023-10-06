using System;

namespace _005_Herencia
{
    // Mamifero en este caso hace de "Superclase"
    internal class Mamifero
    {
        public string nombre;
        
        public Mamifero(string nombre)
        {
            Console.WriteLine($"Ha creado un Mamifero de nombre {nombre}");
            this.nombre = nombre;
        }
    
        public void Respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public void CuidarCria()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public void pensar() 
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        public static void info() 
        {
            Console.WriteLine("Los mamíferos son animales vertebrados que se caracterizan por tener glándulas mamarias \r\nque les permiten alimentar a sus crías con leche materna.\r\nAdemás, suelen tener pelo o piel, y la mayoría de ellos son de sangre caliente.\r\n");
        }
    }
}
