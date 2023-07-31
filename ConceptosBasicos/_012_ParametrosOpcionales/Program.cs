using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_ParametrosOpcionales
{
    internal class Program
    {
        static int suma(int num1, int num2 = 0) => num1 + num2;

        static int suma(int num1, int num2, int num3) => num1 + num2 + num3;

        static double suma(double num1, double num2 = 0) => num1 + num2;

        static double suma(double num1, double num2, double num3) => num1 + num2 + num3;


        static void Main(string[] args)
        {
            //A continuacion llamamos los metodos con los distintos parametros.
            Console.WriteLine(suma(10));

            Console.WriteLine(suma(10, 20));

            Console.WriteLine(suma(10, 20, 30));

            Console.WriteLine(suma(10.5));

            Console.WriteLine(suma(10.5, 20.5));

            Console.WriteLine(suma(10.5, 20.5, 30.5));
           
        }
    }
}
