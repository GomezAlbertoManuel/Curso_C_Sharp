using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrimaria
{
    internal class Tutor
    {
        private string nombre;
        private static int contador = 0;

        public Tutor(string nombre)
        {
            this.Nombre = nombre;
            contador++;
        }

        public static int Contador() 
        {
            return contador;

        }


        public string Nombre { get => nombre; set => nombre = value; }

        public void Escribir (string texto)
        {  // Establecer el color del texto
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(this.nombre + ":  ");

            // Restablecer el color a su valor predeterminado
            Console.ResetColor();

            Console.WriteLine(texto);
        }




    }
}
