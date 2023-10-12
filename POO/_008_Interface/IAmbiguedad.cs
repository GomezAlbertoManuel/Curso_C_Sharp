using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    internal interface IAmbiguedad
    {
        // La ambigüedad entre interfaces en C# ocurre cuando una clase implementa dos o más interfaces
        // que tienen métodos con la misma firma (nombre y parámetros). Esto puede generar confusión
        // en el compilador y requiere que se resuelva explícitamente cuál método se debe utilizar en
        // la clase implementadora.


        // El siguiente metododo solo fue creado para generar una ambiguedad entre interfaces
        String EsRepetido();
    }
}
