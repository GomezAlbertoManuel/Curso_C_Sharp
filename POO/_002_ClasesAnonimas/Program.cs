using System;



namespace _002_ClasesAnonimas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*una clase anónima en C# es una clase sin un nombre específico
             * que se utiliza para definir y crear objetos de manera rápida y temporal.
             * Estas clases se suelen utilizar en situaciones donde solo necesitas una
             * estructura de datos simple y no quieres crear una clase completa con un nombre.
             *
             * Las clases anónimas son útiles cuando necesitas crear objetos simples
             * para un propósito específico sin tener que definir una clase completa.
             * Sin embargo, no se pueden reutilizar en otras partes del código y
             * están limitadas en cuanto a funcionalidad en comparación con las clases con nombre.

             * En el siguiente ejemplo, se ha creado una clase anónima que tiene dos propiedades: "Nombre" y "Edad".
             * Puedes acceder a estas propiedades como lo harías con cualquier objeto.
             */


            var persona = new { Nombre = "Juan", Edad = 30 };

            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");




        }
    }
}
