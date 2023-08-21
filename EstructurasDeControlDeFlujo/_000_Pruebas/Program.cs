using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno manolo = new Alumno();

            Console.WriteLine(manolo);
        }
    }


    class Alumno
    {
        public int edad = 25;

    }
}

