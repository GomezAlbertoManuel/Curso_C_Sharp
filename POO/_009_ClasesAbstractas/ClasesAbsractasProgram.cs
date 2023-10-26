using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_ClasesAbstractas
{
    internal class ClasesAbsractasProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" +
                "Las clases abstractas en C# son como esqueletos de clases que proporcionan una estructura base para otras clases.\r\n" +
                "No se pueden instanciar directamente, lo que significa que no puedes crear objetos directamente " +
                "a partir de una clase abstracta.\r\n\r\n" +
                "Las clases abstractas son útiles cuando quieres definir un conjunto de métodos y propiedades" +
                "que deben estar presentes en las clases derivadas\r\n" +
                "pero no quieres proporcionar una implementación completa para todos ellos." +
                "En cambio, dejas que las clases derivadas proporcionen sus propias implementaciones específicas.\r\n\r\n" +
                "Para crear una clase abstracta, debes usar la palabra clave 'abstract' en la definición de la clase." +
                "Además, puedes declarar métodos abstractos en una clase abstracta, que son métodos sin implementación," +
                "marcados con 'abstract'. Las clases derivadas deben proporcionar una implementación para estos métodos.");

            Console.WriteLine("__________________________________________________\r\n \r\n");

            Console.WriteLine("Escriba nombre del mamifero");
            string nombreMamifero = Console.ReadLine();
            
            Mamiferos mamiferos = new Mamiferos(nombreMamifero);
            
            Console.WriteLine("Es una especie Extinta? true o false (en minuscula)");
            mamiferos.SetExtinto(Convert.ToBoolean(Console.ReadLine()));
            Console.WriteLine(mamiferos.GetExtinto());





        }
    }
}
