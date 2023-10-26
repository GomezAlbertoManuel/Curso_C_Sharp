using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Clases_selladas
{
    // Para declarar una clase sellada se utiliza la palabra reservada "sealed"
    internal sealed class Adolescente : Humano
    {
        public Adolescente(string tipoAnimal, string nombre) : base(tipoAnimal, nombre)
        {
        }
    }
}
