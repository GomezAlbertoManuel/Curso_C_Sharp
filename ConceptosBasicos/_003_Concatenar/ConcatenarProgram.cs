using System;

namespace _003_Concatenar
{
    internal class ConcatenarProgram
    {
        static void Main(string[] args)
        {
            // -MANERAS DE CONCATENAR STRINGS CON VARIABLES O VALORES-

            int edad;
            edad = 39;

            //.Concatenacion normal "+".
            Console.WriteLine("Mi edad es " + edad + " años");
            Console.WriteLine("Si sumamos ambos numeros de mi edad esto da " + (3 + 9) + " (doce)");


            //.interpolacion de cadenas"$" y "{}".
            Console.WriteLine();
            Console.WriteLine($"Mi edad ahora es {++edad} años");
            Console.WriteLine($"Si sumamos ambos numeros de mi edad esto da {4 + 0} (cuatro)");
           
            int valor1 = 1;
            int valor2 = 2;
            int valor3 = 3;
            

            Console.WriteLine("El valor elegido es: {0}", valor1, valor2, valor3, (valor1 + valor3), (7 - 2), 6);
            Console.WriteLine("Te quedaron los siguientes valores: {1}, {2}, {3}, {4}, {5}", valor1, valor2, valor3,(valor1 + valor3), (7-2), 6);
            /*Los valores entre comas son argumentos argumentos que pueden ser escojidos "{}" comenzando desde el valor cero "0" como los arrays.


            /*CURIOSIDAD: Si intentamos incrementar "++" o decrementar "--" dentro de una concatenacion
              los signos deberan ir antes de la variable
            */


        }
    }
}
