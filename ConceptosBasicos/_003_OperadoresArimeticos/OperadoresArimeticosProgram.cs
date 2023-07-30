using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_OperadoresArimeticos
{
    internal class OperadoresArimeticosProgram
    {
        static void Main(string[] args)
        {            
            int numero1 = 10;
            int numero2 = 5;

            // Ejemplo de suma
            int suma = numero1 + numero2;
            Console.WriteLine("Suma: " + suma);

            // Ejemplo de resta
            int resta = numero1 - numero2;
            Console.WriteLine("Resta: " + resta);

            // Ejemplo de multiplicación
            int multiplicacion = numero1 * numero2;
            Console.WriteLine("Multiplicación: " + multiplicacion);

            // Ejemplo de división
            int division = numero1 / numero2;
            Console.WriteLine("División: " + division);

            // Ejemplo de módulo
            int modulo = numero1 % numero2;
            Console.WriteLine("Módulo: " + modulo + "\r\n");

            // Ejemplo de incremento en 1
            int numero = 7;
            Console.WriteLine("Valor original: " + numero);
            numero++; // Incremento en 1
            Console.WriteLine("Incremento en 1: " + numero + "\r\n");

            // Ejemplo de incremento en un numero especifico
            Console.WriteLine("Valor original: " + numero);
            numero += 5; // Incremento en 5
            Console.WriteLine("Incremento en 5: " + numero + "\r\n");

            // Ejemplo de decremento en 1
            Console.WriteLine("Valor original: " + numero);
            numero--;
            Console.WriteLine("Decremento en 1: " + numero + "\r\n");

            // Ejemplo de decremento en un numero especifico
            Console.WriteLine("Valor original: " + numero);
            numero -= 5; // decremento en 5
            Console.WriteLine("decremento en 5: " + numero + "\r\n");


        }
    }
}
