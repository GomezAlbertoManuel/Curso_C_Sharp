using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrimaria
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("MIA");
            Tutor tutor = new Tutor (null);            
            string Bienvenida()
            {
                string bienvenida;

                if (Tutor.Contador() == 1)
                {
                    bienvenida = "Eres el primer tutor";
                }
                else { bienvenida = $"Contigo van {Tutor.Contador()} tutores"; }

                return bienvenida;
            }


            estudiante.Escribir($"Hola soy tu estudiante virtual \"{estudiante.Nombre}\".");
            estudiante.Escribir("¿Cual es tu nombre?");

            tutor.Nombre = Console.ReadLine();

            estudiante.Escribir($"Hola {tutor.Nombre}. {Bienvenida()} ");
            estudiante.Escribir("Escribe ayuda para conocer mis instrucciones");
            tutor.Escribir(Console.ReadLine());

            while ( Console.ReadLine() != "ayuda") 
            {
                estudiante.Escribir("Escribe ayuda para conocer mis instrucciones");
                tutor.Escribir(Console.ReadLine());
            }



        }
    }
}
