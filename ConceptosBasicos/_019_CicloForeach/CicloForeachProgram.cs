using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_CicloForeach
{
    internal class CicloForeachProgram
    {
        static void Main(string[] args)
        {
            // El bucle foreach se utiliza para recorrer colecciones, como arrays, listas o diccionarios,
            // de manera sencilla y eficiente.
            // En cada iteración, el bucle asigna automáticamente el valor del elemento actual de la colección
            // a una variable temporal, que especificas después de la palabra clave 'foreach'.
            // No es necesario llevar un control del índice ni calcular la longitud de la colección manualmente.


            // El bucle foreach es especialmente útil cuando quieres iterar sobre todos los elementos
            // de una colección sin preocuparte por los detalles de la implementación.


            int[] numImpares = new int[5] { 1, 3, 5, 7, 9 };
            
            int[] numPares = { 2, 4, 6, 8, 10 };

            var nombre = new[] { "Manuel", "Silvia", "Luciano", "Lucas", "Onna" };
            var edad = new[] { 41, 36, 15, 11, 5 };
            var altura = new[] { 1.7, 1.55, 1.50, 1.3, 1.1 };


            var arraysClasesAnonima = new[]
            {
                new{ nombre = "Juan", edad = 25 },

                new { nombre = "Jose", edad = 30 },

                new { nombre = "Pedro", edad = 45 },                
            };

            Parientes[] pariente = new Parientes[2];

            pariente[0] = new Parientes("Gabriela", 43, "la Gabi");
            pariente[1] = new Parientes("Gustavo", 32, "Gusti");

            // En el bucle foreach hay que crear una variable a la que se le llama iterador
            // tiene que ser del mismo tipo que estamos almacenando en el array.
            // Aunque utilizando la palabra reservada "var" detecta automaticamente el tipo de varible.
            // UN INCONVENIENTE QUE TIENE ES QUE SI UTILIZAMOS UN ARRAY QUE TIENE DECLARADO LA CANTIDAD 
            // DE VALORES QUE VA A TENER, NOS VA A GENERAR UNA EXCEPCION SI ALGUNA MATRIZ DEL ARRAY ESTA VACIO.

            foreach (var cadaUno in pariente)
            {
                Console.WriteLine(cadaUno.apodo);
            }

        }
    }
}
