using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    internal class ClicoForProgram
    {
        static void Main(string[] args)
        {
         
            for (int edadLucia = 1;edadLucia  < 15; edadLucia++)
            {
                Console.WriteLine($"lucia tiene {edadLucia} años \r\n faltan {15 - edadLucia} años para sus quinces\r\n");

            }

            Console.WriteLine("\r\nAl fin lucia  tiene Quince Años");
         


            //---------------------------------------------------------------------



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
