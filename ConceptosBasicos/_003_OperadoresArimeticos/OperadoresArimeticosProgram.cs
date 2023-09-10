using System;

namespace _003_OperadoresArimeticos
{
    internal class OperadoresArimeticosProgram
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 5;

            // Suma
            int suma = numero1 + numero2;
            Console.WriteLine("Suma: " + suma);

            // Resta
            int resta = numero1 - numero2;
            Console.WriteLine("Resta: " + resta);

            // Multiplicación
            int multiplicacion = numero1 * numero2;
            Console.WriteLine("Multiplicación: " + multiplicacion);

            // División
            int division = numero1 / numero2;
            Console.WriteLine("División: " + division);

            // Módulo
            int modulo = numero1 % numero2;
            Console.WriteLine("Módulo: " + modulo + "\r\n");

            // Incremento en 1 (++)
            int numero3 = 7;
            Console.WriteLine("Valor original: " + numero3 + "\r\n");
            numero3++; // Incremento en 1
            Console.WriteLine("Incremento en 1: " + numero3 + "\r\n");

            // Decremento en 1 (--)
            numero3--;
            Console.WriteLine("Decremento en 1: " + numero3 + "\r\n");

            // Operador de suma y asignación (+=):
            numero3 += 5; // Esto es equivalente a numero3 = numero3 + 5;
            Console.WriteLine("Incremento en 5: " + numero3 + "\r\n");

            // Operador de resta y asignación (-=):
            numero3 -= 5; // Esto es equivalente a numero3 = numero3 - 5;
            Console.WriteLine("decremento en 5: " + numero3 + "\r\n");

            // Operador de multiplicación y asignación (*=):
            numero3 *= 2; // Esto es equivalente a numero3 = numero3 * 4;
            Console.WriteLine("Operador de multiplicación y asignación (2): " + numero3 + "\r\n");


            // Operador de división y asignación (/=):            
            numero3 /= 2; // Esto es equivalente a numero3 = numero3 / 2;
            Console.WriteLine("Operador de división y asignación (2): " + numero3 + "\r\n");


            // Operador de módulo y asignación (%=):
            numero3 %= 2; // Esto es equivalente a numero3 = numero3 % 7;
            Console.WriteLine("Operador de módulo y asignación (2): " + numero3 + "\r\n");


        }
    }
}
