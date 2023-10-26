using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_ClasesAbstractas
{
    // "Mamiferos" hereda de "Animales" que es una clase abstracta.
    internal class Mamiferos : Animales
    {
        
        private string nombreMamifero;

        public Mamiferos(string nombre) 
        {
            nombreMamifero = nombre;
        }

        // El metodo "GetNombre" fue declara en la clase abstracta "Animales"
        // Eso nos obliga a tener que desarrollar el metodo en esta clase que esta heredando y, ademas,
        // debe ser implementado con la palabra clave "override", para que sobreescriba al metodo.
        // de otra manera, solamente estaria ocultando al metodo de la clase abstracta
        public override void GetNombre()
        {
            Console.WriteLine("El nombre del Mamifero es: " + nombreMamifero );
        }
      

        
    }
}
