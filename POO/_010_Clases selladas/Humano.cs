using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Clases_selladas
{    
    internal class Humano : Animal
    {
        public Humano(string tipoAnimal, string nombre) : base(tipoAnimal, nombre) 
        {
        }


        // Para sellar un metodo se utiliza la palabra reservada "sealed"
        public sealed override void Pensar()
        {
            Console.WriteLine("Proceso información para tomar decisiones, resolver problemas y formar opiniones.");
        }
    }
}
