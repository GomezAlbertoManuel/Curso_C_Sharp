using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Alcances
/*el alcance(también conocido como ámbito) se refiere a la visibilidad y disponibilidad de una variable, constante, función o clase en diferentes partes del código.El alcance define en qué partes del programa una entidad(como una variable o función) puede ser referenciada y utilizada.

Existen principalmente tres niveles de alcance en C#:

1. Alcance Local: Una variable declarada dentro de un bloque de código, como una función o un bucle, tiene un alcance local y solo es accesible dentro de ese bloque específico.Cuando el bloque se ejecuta, la variable se crea y cuando el bloque se completa, la variable se destruye y su memoria se libera.

2. Alcance de Bloque: El alcance de bloque se aplica a bloques de código dentro de una función, como bucles for, while, if, etc. Las variables declaradas dentro de estos bloques solo son accesibles dentro de esos bloques específicos.


3. Alcance Global: Las variables declaradas fuera de cualquier función o bloque tienen un alcance global. Esto significa que estas variables son accesibles desde cualquier lugar dentro   del archivo de código o incluso en otros archivos si se declara como pública.



Es importante tener en cuenta que el alcance puede afectar la vida útil y el comportamiento de las variables. Las variables locales son destruidas al salir del bloque en el que se declaran, mientras que las variables globales persisten durante toda la ejecución del programa.

Una buena práctica es mantener el alcance lo más limitado posible para evitar conflictos y facilitar el mantenimiento del código. En general, es recomendable utilizar variables locales siempre que sea posible y solo utilizar variables globales cuando sea absolutamente necesario compartir información entre diferentes partes del programa.

*/

{
    internal class AlcancesProgram
    {
        static int AlcanceLocal()
        {
            Console.WriteLine("escriba un valor entero por favor");
            int local = int.Parse(Console.ReadLine());

            return local;
        }

        static void Main(string[] args)
        {
            int numero = AlcanceLocal();
            Console.WriteLine($"Su numero mas mi numero da {numero + 20}");
        }
    }
}
