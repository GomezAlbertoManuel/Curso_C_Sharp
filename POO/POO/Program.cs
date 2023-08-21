using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            // Creación de un objeto de la clase Persona
            Persona persona1 = new Persona("Juan", 25);

            // Acceso a las propiedades y métodos del objeto
            Console.WriteLine($"Nombre: {persona1.Nombre}");
            Console.WriteLine($"Edad: {persona1.Edad}");
            persona1.Presentarse();*/

            Persona persona1 = new Persona();

            Console.WriteLine(persona1.Nombre = "leonardo " +  (persona1.Edad = 25)) ;

            Console.WriteLine(persona1.Altura = 25.5);
            Console.WriteLine("texto para dividir");

            Console.WriteLine(persona1.Altura);
        }
    }
}
