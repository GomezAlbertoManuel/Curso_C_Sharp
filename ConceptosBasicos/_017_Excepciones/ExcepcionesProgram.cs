using System;

namespace _017_Excepciones
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
                    Console.WriteLine(ex.Message);
                }
                
                catch (FormatException ex)
                {
                    Console.WriteLine("solo puede ingresar numeros");
                    numeroIngresado = 111;
                    Console.WriteLine(ex.Message);
                }
                if (numeroIngresado == 111) Console.WriteLine("Trata otra vez \r\n");
                else
                {
                    if (numeroIngresado > numeroPensado) Console.WriteLine("El numero es menor \r\n");
                    if (numeroIngresado < numeroPensado) Console.WriteLine("El numero es mayor \r\n");
                }





            } while (numeroPensado != numeroIngresado);

            Console.WriteLine("Muy bien has acertado!!!");
        }
    }
}
