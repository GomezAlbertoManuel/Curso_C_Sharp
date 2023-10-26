using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Clases_selladas
{
    internal class ClasesSelladasProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" +
                "Las clases selladas en C# son clases que no pueden ser heredadas o derivadas por otras clases.\r\n" +
                "Cuando una clase se marca como 'sealed', significa que no se pueden crear subclases a partir de ella.\r\n\r\n" +
                "Las clases selladas son útiles cuando deseas evitar que otros desarrolladores extiendan o modifiquen" +
                "una clase específica. Esto puede ser útil para preservar la integridad de una clase base o para garantizar" +
                "que una clase concreta no sea modificada en el futuro.\r\n\r\n" +
                "Para crear una clase sellada, debes utilizar la palabra clave 'sealed' en la definición de la clase." +
                "Una vez que una clase se ha sellado, no se pueden heredar de ella, y cualquier intento de crear una subclase" +
                "generará un error de compilación.\r\n\r\n" +
                "Es importante tener en cuenta que no puedes marcar una clase como abstracta y sellada al mismo tiempo, ya que" +
                "esto sería contradictorio. Las clases selladas son final y no pueden tener subclases, mientras que las clases" +
                "abstractas se diseñan precisamente para ser heredadas y extendidas por subclases.\r\n\r\n" +
                "Tambien podemos sellar metodos para que no puedan ser modificados por otras clases\r\n" +
                "Aunque sellar un metodo en una clase sellada seria redundar ya que ninguna clase\r\n" +
                "va a heredar de una clase sellada");



            Console.WriteLine("__________________________________________________\r\n \r\n");

            Humano manolo = new Humano("Persona", "Manuel");

            Console.WriteLine(manolo.Nombre + " " + manolo.TipoAnimal);



            Console.WriteLine("__________________________________________________\r\n \r\n");



            Adolescente luciano = new Adolescente("Persona", "Lucano");

            luciano.Pensar();



        }






    }
}
