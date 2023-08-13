using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int numeroPensado = numAleatorio.Next(0, 100);
           
            Console.WriteLine("Estoy pensando un número del 1 al 100. \r\nAdivina cual es\r\nINGRESA UN NUMERO");
            int numeroIngresado = int.Parse(Console.ReadLine());

            while (numeroPensado != numeroIngresado)
            {                 
                if (numeroIngresado > numeroPensado) Console.WriteLine("El numero es menor \r\n");
                else Console.WriteLine("El numero es mayor \r\n");

                numeroIngresado = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muy bien has acertado!!!");


            //---------------------------------------------------------
                        
            int numeroPensado2 = numAleatorio.Next(0, 100);        

            Console.WriteLine("Estoy pensando un número del 1 al 100. \r\nAdivina cual es\r\nINGRESA UN NUMERO");

            do
            {
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado > numeroPensado2) Console.WriteLine("El numero es menor \r\n");
                else Console.WriteLine("El numero es mayor \r\n");


            } while (numeroPensado != numeroIngresado);

            Console.WriteLine("Muy bien has acertado!!!");

        }
    }
}
