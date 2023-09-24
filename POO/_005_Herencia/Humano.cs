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
        //public new string[] hembra = new string[3];
        public Humano(string nombre, bool hembra, int edad) : base (nombre, hembra)
        { 
            Console.WriteLine($"Pertenesiente a la clase Humano con {edad} años.");
            this.edad = edad;
        }

        new public void pensar()
        {
            Console.WriteLine("Pensamiento avanzado");
        }

        public void Charlar() 
        {
            Console.WriteLine($"Hola!!\r\nMe llamo {nombre}, cuando gustes nos juntamos a charlar.");
        }
        
    }
}
