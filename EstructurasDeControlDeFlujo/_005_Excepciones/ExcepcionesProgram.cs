using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Excepciones
{
    internal class ExcepcionesProgram
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int numeroPensado = numAleatorio.Next(0, 100);
            int numeroIngresado;
           

         
            Console.WriteLine(numeroPensado);
            Console.WriteLine("Estoy pensando un nuevo número del 0 al 100. \r\nAdivina cual es\r\nINGRESA UN NUMERO");
          
            do
            {
                try
                {
                    numeroIngresado = int.Parse(Console.ReadLine());
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("numero demasiado largo");
                    numeroIngresado = 111;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("solo puede ingresar numeros");
                    numeroIngresado = 111;
                }
                if (numeroIngresado == 111) Console.WriteLine("Trata otra vez \r\n");
                else
                {
                    if (numeroIngresado > numeroPensado) Console.WriteLine("El numero es menor \r\n");
                    if (numeroIngresado < numeroPensado) Console.WriteLine("El numero es mayor \r\n");

1                }





            } while (numeroPensado != numeroIngresado);

            Console.WriteLine("Muy bien has acertado!!!");
        }
    }
}
