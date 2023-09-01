using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ImportarMetodosStatic
{
    internal class Matematicas
    {
        public static int Multiplicar(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;

        }

        public static int Multiplicar(int numero1, int numero2, int numero3)
        {
            int resultado = numero1 * numero2 * numero3;
            return resultado;
        }

    }
}
