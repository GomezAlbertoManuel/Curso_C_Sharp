using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constantes
{
    internal class ConstantesProgram
    {
        static void Main(string[] args)
        {
            //El nombre de las constantes, por convención, se escriben en MAYUSCULA
            const int VALOR = 5;
            const int VALOR2 = 6;

            Console.WriteLine("El valor elegido es: {0}", VALOR, VALOR2);
            Console.WriteLine();

            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio para calcular el area de un circulo.");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * PI;
           
            Console.WriteLine($"El area del circulos es: {area}");
        }
    }
}
