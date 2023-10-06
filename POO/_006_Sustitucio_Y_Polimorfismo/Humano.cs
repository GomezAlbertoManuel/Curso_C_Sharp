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
            Console.WriteLine($"Pertenesiente a la clase Humano con {edad} años.");
            this.edad = edad;
        }

        // la palabra reservada "new" aqi se utiliza para decirle a C# que
        // consientemente quiero ocultar el metodo Pensar de la clase madre.
        // Esta situacion solo se da cuando en la clase madre hay un metodo
        // con el mismo nombre y con la misma cantidad y tipo de parametros.
        new public void Pensar()
        {
            Console.WriteLine($"Soy {nombre} tengo pensamiento avanzado");
        }

        public void Charlar() 
        {
            Console.WriteLine($"Hola!!\r\nMe llamo {nombre}, cuando gustes nos juntamos a charlar.");
        }

        public override void Desplazar() 
        { Console.WriteLine($"Soy {nombre} Puedo caminar \r\n"); }

        public new static void Info()
        {
            Console.WriteLine("Un humano es una especie de ser viviente con inteligencia, capacidad de comunicación compleja, \r\nemociones, y habilidades para crear herramientas y organizarse en sociedades\r\n");
        }


    }
}
