using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Clases
{
    internal class ClasesProgram
    {
        static void Main(string[] args)
        {
            // Creación de un objeto de la clase Persona sin parametros
            Persona persona1 = new Persona();

            // Acceso a las propiedades y métodos del objeto
            persona1.Nombre = "leonardo ";
            persona1.Edad = 25;
            Console.WriteLine($"Nombre: {persona1.Nombre}");
            Console.WriteLine($"Edad: {persona1.Edad}");            
            persona1.Presentarse();

            Console.WriteLine("\r\n------------\r\n");

            // Creación de un objeto de la clase Persona con parametros
            Persona persona2 = new Persona("Juan", 25);

            // Acceso a las propiedades y métodos del objeto
            Console.WriteLine($"Nombre: {persona2.Nombre}");
            Console.WriteLine($"Edad: {persona2.Edad}");
            persona2.Presentarse();
            Console.WriteLine($"Y mi altura es: {persona2.Altura = 1.7}mt");
        }
    }
}
