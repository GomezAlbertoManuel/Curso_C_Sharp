﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrimaria
{
    internal class Estudiante
    {

        private string nombre;

        public Estudiante(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public void Escribir(string texto)
        {  // Establecer el color del texto
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write($"{this.nombre}: " + texto);

            // Restablecer el color a su valor predeterminado
            Console.ResetColor();

          



        }


    }
}