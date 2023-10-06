using System;

namespace _005_Herencia
{
    // Mamifero en este caso hace de "Superclase"
    internal class Mamifero
    {
        public string nombre;  

        
        public Mamifero(string nombre)
        {
            Console.WriteLine($"\r\n \r\nHa creado un Mamifero de nombre {nombre}\r\n");
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



    }
}
