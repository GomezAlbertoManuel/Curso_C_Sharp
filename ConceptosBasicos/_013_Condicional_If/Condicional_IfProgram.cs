using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Condicional_If
{
    internal class Condicional_IfProgram
    {
        static void Main(string[] args)
        {
            // Utilizando las variables boleanas "valorVerdadero" y "valorFalso vamos a tratar de ejemplificar situaciones de "If"             
            bool valor1 = true;
            bool valor2 = false;

            // Igual a (==)
            if (valor1 == true)
            {
                Console.WriteLine("Si el valor1 ES verdadero, se va a poder leer este texto");
            }


            // No igual a (!=)
            if (valor2 != true)
            {
                Console.WriteLine("Si el valor2 NO ES, verdadero se va a poder leer este texto");
            }


            // Doble negacion "!=" + "!valor"
            if (valor2 != !false)
            {
                Console.WriteLine("\r\nNegar dos veces algo es afirmar.\r\nComo en este caso estoy diciendo -si el valor2 no es no falso " +
                                  "\r\nEsto se traduce a: si el valor2 es falso\r\n");
            }

            Console.WriteLine("Para hacer comparaciones voy a pedirte que ingreses 3 numeros diferentes.\r\nIngresa el primero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("tercero");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\r\nTengo el primer numero que vale {num1}, el segundo numero que vale {num2} y el tercero que vale {num3}\r\n");

            // Mayor que (>)            
            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es mayor que el segundo.\r\n");
            }
            else
            {
                Console.WriteLine("El Primer numero es menor que el segundo.\r\n");
            }

            // Menor que(<)
            if (num1 < num3)
            {
                Console.WriteLine("El primer numero es menor que el tercero.\r\n");
            }
            else
            {
                Console.WriteLine("El primer numero es mayor que el segundo.\r\n");
            }

            /* 
             * TIP: Cuando solamente necesitamos ejecutar una sola linea de codigo despues de un "if" o un "else"
             *      se puede prescindir de las llaves "{}".
             */

            // Mayor o igual que(>=) + Menor o igual que(<=) + valor logico Y (&&)

            Console.WriteLine("\r\nPor Favor escribe un numero mayor o igual que 10\r\n");

            num1 = double.Parse(Console.ReadLine());

            if (num1 >= 10) Console.WriteLine("r\nMuy bien!!! veo que sabes lo que es un numero mayor r\n");
            else Console.WriteLine("Valor invalido");


            // ESTRUCTURA ELSE IF
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nPor favor ahora escribe un numero menor que 10r\n");
                num1 = double.Parse(Console.ReadLine());

                if (num1 <= 10 || num1 >= 5) Console.WriteLine("Escogiste un numero entre 5 y 10");
                else if (num1 <= 5 || num1 >= 0) Console.WriteLine("escogiste un numero entre 0 y 5");
                else if (num1 < 0) Console.WriteLine("No vale numeros negativos");
                else if (num1 > 10) Console.WriteLine("No vale numero mayores a 10");
                else Console.WriteLine("valor no valido");

            }


        }
    }
}
