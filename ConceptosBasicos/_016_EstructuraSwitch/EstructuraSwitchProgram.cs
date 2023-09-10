using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_EstructuraSwitch
{
    internal class EstructuraSwitchProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor elija una opción para viajar: tren, colectivo o auto");


            string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "tren":
                    Console.WriteLine("El tren es rapido, pero viaja muy apretado");
                    break;

                case "colectivo":
                    Console.WriteLine("El colectivo da muchas vueltas para llegar");
                    break;

                case "auto":
                    Console.WriteLine("La mejor opcion de todas, el auto por lejos");
                    break;

                default:
                    Console.WriteLine("Estas elijiendo una opción incorrecta");
                    break;
            }

            Console.WriteLine("\r\nExcelente Tu eleccion\r\n \r\n");

            //---------------------------------------------------------------------
            Console.WriteLine("Por favor elija nuevamente  una opción para viajar: tren, colectivo, avion o auto");


            eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "tren":
                case "colectivo":
                case "avion":
                    Console.WriteLine("eljio un medio de transporte masivo");
                    break;

                case "auto":
                    Console.WriteLine("medio de transporte personal");
                    break;

                default:
                    Console.WriteLine("Opcion defaul");
                    break;

            }
        }
    }
}
