using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_ClasesAbstractas
{
    // Las clases abstractas no se pueden instanciar directamente,
    // lo que significa que no puedes crear objetos de estas clases.
    // Las clases abstractas en C# son como esqueletos de clases que proporcionan una estructura base para otras clases.

    // Para declarar una clase abstracta, utilizamos la palabra reservada "abstract"
    abstract class Animales
    {
        // en el caso que quisieramos crear un campo en una clase abstracta que pueda ser utilizadas por las clases derivadas
        // una manera seria declararlo "protected".
        // de esta manera pueden ser utilizadas por las clases que heredan directamente de ella
        // tambien podria declararlo "private" y crear un metodo para acceder a el.
        // por ultimo podria declararlo publico, pero no es recomendado.
        private bool extinto;

        // En una cxlase abstracta podemos crear metodos que pueden ser utilizados por todas las clases derivadas
        public void Respirar() 
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        // Los metodos abstractos funcionan de la misma manera que los metodos declarados en una interface.
        // Estos solamente se declaran y obligan a las clases derivadas a ser implementados.
        // Con la diferencia que aqui hay que declararlos "public" porque sino genera un error de compilacion.
        // y las clases que heredan deben sobreescribir ("override") al metodo
        public abstract void GetNombre();

        public bool GetExtinto() 
        { return extinto; }

        public void SetExtinto(bool extinto) 
        { this.extinto = extinto; }


    }
}
