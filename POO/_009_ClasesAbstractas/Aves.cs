using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _009_ClasesAbstractas
{
    internal class Aves : Animales
    {
        private string nombreAve;

        public Aves(string nombreAve)
        {
            this.nombreAve = nombreAve;
        }

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del ave es {nombreAve}");
        }
    }
}
