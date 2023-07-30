using System;

namespace _002_DeclararVariables
{
    internal class DeclararVariablesProgram
    {
        static void Main(string[] args)
        {
            // -MANERAS DE DECLARAR E INICIALIZAR VARIABLES-

            //.Declar en lineas separadas luego inicializarlas.
            int edad1;
            int edad2;
            string nombre1;
            string nombre2;

            edad1 = 39;
            edad2 = 34;
            nombre1 = "Manolo";
            nombre2 = "Silvia";

            Console.WriteLine(nombre1 + " " + edad1);
            Console.WriteLine(nombre2 + " " + edad2);


            //.Declarar todo en una misma linea luego inicializarlas.
            int edad3, edad4, edad5;
            string nombre3, nombre4, nombre5;

            edad3 = 5;
            nombre3 = "Onna";
            edad4 = 11;
            nombre4 = "Lucas";
            edad5 = 16;
            nombre5 = "Luciano";

            Console.WriteLine(nombre3 + " " + edad3);
            Console.WriteLine(nombre4 + " " + edad4);
            Console.WriteLine(nombre5 + " " + edad5);


            //.Declarar e inicializar en una misma linea
            int edad6 = 75;
            string nombre6 = "abuelo";

            Console.WriteLine(nombre6 + " " + edad6);

            int edad7 = 25, edad8 = 33;
            string nombre7 = "Tia", nombre8 = "Prima";

            Console.WriteLine(nombre7 + " " + edad7);
            Console.WriteLine(nombre8 + " " + edad8);


            //.Inicializar en una misma linea varias variabes con un mismo valor
            int edad9, edad10, edad11;
            string nombre9, nombre10, nombre11;

            edad9 = edad10 = edad11 = 11;
            nombre9 = nombre10 = nombre11 = "Lucas";

            Console.WriteLine($"Los amigos de {nombre9} se llaman igual que el ({nombre10} y {nombre11}), ademas tienen {edad9}, {edad10} y {edad11} años");


            //.Asigna automaticamente el tipo de variable en tiempo de ejecucion "var" (Declaracion implicita)
            var edad12 = 45;
            var nombre12 = "Cuñado";

            Console.WriteLine(nombre12 + " " + edad12);

            /* En este tipo de declaracion es obligatorio iniciar la variable en la misma linea
             * Ademas, no se puede asignar otro tipo de valor al boleo a la variable.
             * Por Ej. darle un valor del tipo flotante a uno que inicio como entero 
             * var edad12 = 45;
             * edad12 = 46.5; <-esto no se puede, porque el valor inicio como entero.*/

                        
        }
    }
}
