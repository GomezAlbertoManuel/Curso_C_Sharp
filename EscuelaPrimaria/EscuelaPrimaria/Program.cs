using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrimaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("MIA");
            Tutor tutor = new Tutor("Manuel");

            estudiante.Escribir($"Hola soy tu estudiante virtual \"{estudiante.Nombre}\"");
            

            tutor.Hablar("Buenos dias señorita");
       
        }
    }
}
