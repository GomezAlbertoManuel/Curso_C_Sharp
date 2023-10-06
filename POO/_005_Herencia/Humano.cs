using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
    // Humano Hereda las propiedades de Mamifero (Es subclase de la misma).
    internal class Humano : Placentarios
    {
        public int edad;
        

        public Humano(string nombre, bool hembra, int edad) : base (nombre, hembra)
        { 
            Console.WriteLine($"Pertenesiente a la clase Humano con {edad} años.\r\n \r\n");
            this.edad = edad;
        }

        public void Charlar() 
        {
            Console.WriteLine($"Me llamo {nombre}, cuando gustes nos juntamos a charlar.");
        }



    }
}
