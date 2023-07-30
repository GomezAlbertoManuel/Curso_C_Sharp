using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_OperadoresLogicos
{
    internal class OperadoresLogicosProgram
    {
        static void Main(string[] args)
        {
            bool condicion1 = true;
            bool condicion2 = false;

            // Operador AND (&&)
            if (condicion1 && condicion2)
            {
                Console.WriteLine("Ambas condiciones son verdaderas.");
            }
            else
            {
                Console.WriteLine("Al menos una de las condiciones no es verdadera.");
            }

            // Operador OR (||)
            if (condicion1 || condicion2)
            {
                Console.WriteLine("Al menos una de las condiciones es verdadera.");
            }
            else
            {
                Console.WriteLine("Ninguna de las condiciones es verdadera.");
            }

            // Operador NOT (!)
            if (!condicion1)
            {
                Console.WriteLine("La condición 1 es falsa.");
            }
            else
            {
                Console.WriteLine("La condición 1 es verdadera.");
            }
        }
    }
}
