using System;

namespace _014_CicloFor
{
    internal class CicloForProgram
    {
        static void Main(string[] args)
        {

            for (int edadLucia = 1; edadLucia < 15; edadLucia++)
            {
                Console.WriteLine($"lucia tiene {edadLucia} años \r\n faltan {15 - edadLucia} años para sus quinces\r\n");

            }

            Console.WriteLine("Al fin lucia  tiene Quince Años\r\n");


            // El bucle for tambien puede ser de manera decreciente
            Console.WriteLine("\r\nBucle for regresivo \"--\"\r\n");
            for (int i = 10;i > 0;i--) 
            {
                Console.WriteLine("El siguiente valor representa el valor del indice: " + i);
            }

            Console.WriteLine("\r\n \r\n");


            //---------------------------------------------------------------------


            // Bucle for anidado
            for (int tabla = 1; tabla <= 10; tabla++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{tabla} x {i} = {tabla * i}");
                }
            }

        }
    }
}
