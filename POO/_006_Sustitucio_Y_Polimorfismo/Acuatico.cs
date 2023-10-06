using _005_Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Sustitucio_Y_Polimorfismo
{
    internal class Acuatico : Placentarios
    {
        public Acuatico(string nombre, bool hembra) : base(nombre, hembra)
        {
        }

        new public virtual void Desplazar()
        { Console.WriteLine($"soy {nombre} puedo nadar \r\n"); }

    }
}
