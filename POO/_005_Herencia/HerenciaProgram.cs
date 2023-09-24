using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
    internal class HerenciaProgram
    {
        // Al utilizar clases que heredan de otras, podemos utilizar las propiedades y metodos heredadas de las mismas.

        static void Main(string[] args)
        {
            Mamifero.info();
            // las clases hijas heredan los constructores de las superclases.
            // En este ejemplo tenemos la clase "Humano" que hereda de "Placentario" que hereda de "Mamifero"
            // En la clase "Mamifero" el constructor nos solicita un parametro de tipo "string" (nombre).
            // En la subclase "Placentario" estamos obligados a repetir ese dato y añadimos el "apellido"
            // Y por ultimo en la subclase "Humano" tenemos que repetir los dos datos anteriores y añadimos la "edad". 
            Mamifero ballena = new Mamifero("Willy");
            Console.WriteLine();
            Placentarios caballo = new Placentarios("Tiro", false);
            Console.WriteLine();
            Humano manolo = new Humano("Manuel", false, 40);
            Console.WriteLine();
            // No es necesario que sea de esta manera,pero si creamos uno o varios constructores en la clase Madre (superclase)
            // esto nos obliga aque las clases hijas mantengan ese constructor.

            Console.WriteLine("metodo pensar");
            manolo.pensar();

            //---------------------------------------------------------------------------------



            // Solo de manera ilustrativa coloque un campo de clase público en cada clase para ver la herencia
            // Mamifero "nombre"  -  Placentario "apellido"  -  Humano "edad"  -

            ballena.nombre = "Waldo"; // Mamifero solo tiene el campo "nombre"

            caballo.nombre = "Canela";
            caballo.hembra = true; // Placentario Hereda el campo nombre y añade "apellido"
            string caballoHembra;
            if (caballo.hembra) { caballoHembra = "hembra"; }
            else {caballoHembra = "macho"; }

            manolo.nombre = "Alberto";
            manolo.hembra = false;
            manolo.edad = 41; // Humano hereda los dos campos anteriores y añade "edad"
            String humanoHembra;
            if (manolo.hembra) { humanoHembra = "hembra"; }
            else { humanoHembra = "macho"; }


            // La siguiente linea de codigo es solo para visualizar los cambios
            Console.WriteLine($"Los datos fueron modificados:\r\n" +
                $"Mamifero: {ballena.nombre}\r\n" +
                $"Placentario: {caballo.nombre}, {caballoHembra}\r\n" +
                $"Humano: {manolo.nombre}, {humanoHembra}, {manolo.edad}");

            Console.WriteLine();



            //---------------------------------------------------------------------------------



            //



        }
    }
}
