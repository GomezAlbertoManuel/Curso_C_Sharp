using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    internal class InterfacesProgram
    {
        static void Main(string[] args)
        {
            AvisosTrafico aviso1 = new AvisosTrafico();
            aviso1.MostrarAviso();

            AvisosTrafico aviso2 = new AvisosTrafico("Jefatura Provincial", "Exceso de velocidad", "04/10/2023");

            Console.WriteLine(aviso2.GetFecha());

            aviso2.MostrarAviso();
        }
    }
}
