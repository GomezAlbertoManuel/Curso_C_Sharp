using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeArrays
{
    internal class MetodosDeArraysProgram
    {
        static void Main(string[] args)
        {
            int[] pares = new int[4];

            pares[0] = 2;
            pares[1] = 4;
            pares[2] = 6;
            pares[3] = 8;

            Console.WriteLine("Recorrido por el array \"pares\":");
            RecorrerArray(pares);
            
            Console.WriteLine($"\r\nHasta este punto el array \"pares\" contiene los siguientes valores: ");
            for (int i = 0;i < pares.Length; i++) 
            {
                Console.WriteLine($"Posición {i}: {pares[i]}");
            }

            Console.WriteLine("\r\nAhora vamos a sumarle valor a cada item. \r\nPor Favor escribe un valor para sumar a cada item");
            int valorSumado = int.Parse( Console.ReadLine() );

            int[] arrayModificado = RecorrerArrayYSumar(pares, valorSumado);

            Console.WriteLine("\r\nEl array quedó de la siguiente manera:");
            for (int i = 0; i < arrayModificado.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {arrayModificado[i]}");
            }

            // Para poder acceder al array creado en el metodo "CrearArrayString"
            // debo crear un array que tenga como parametro el mismo metodo.
            // de otra manera no se podria acceder, porque el ambito del array esta dentro del metodo.
            string[] accesoAlArrayCreado = CrearArrayString();

            Console.WriteLine("\r\nAcceso desde el metodo \"Main\"");
            // Ahora puedo acceder a cualquier item del array creado en el metodo
            // a traves del array "accesoAlArrayCreado" que se encuentra en este ambito.
            int contador = 0;
            foreach (string i in accesoAlArrayCreado) 
            {
                Console.WriteLine($"Posicion {contador++}: {i}"); 
            }

        }

        // El siguiente metodo recibe como parametro un array
        // Recorre cada item del mismo y lo imprime en consola sumandole "10", pero
        // NO le suma "10" a cada valor del array ya que el valor "i" solo es un iterador.
        // para que la suma de  "10" se refleje en el array habria que hacerlo con un bucle for. 
        static int[] RecorrerArray(int[] array) 
        {
            foreach (int i  in array) 
            {                
                Console.WriteLine(i);
            }        
            return array;
        }
        
        /*
        static void RecorrerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }            
        }
        */

        static int[] RecorrerArrayYSumar(int[] array,int valorSumado) 
        {
            for (int i = 0;i < array.Length;i++) 
            {
                array[i] += valorSumado;
            }

            return array;
        }

        static string[] CrearArrayString() 
        {
            Console.WriteLine("\r\nAhora crearemos un array del tipo \"string\". ¿Cuantos Items desea en el Array?");
            int longitud = int.Parse(Console.ReadLine());

            string[] arrayCreado = new string[longitud];
            
            for (int i = 0; i < longitud; i++) 
            {
                Console.WriteLine($"Ingresa valor para la posición {i}");
                arrayCreado[i] = Console.ReadLine();
            }
            Console.WriteLine($"\r\nSe ha creado el Array con los siguientes {longitud} valores: ");

            for (int i = 0; i < arrayCreado.Length; i++) 
            {
                Console.WriteLine($"Posición {i}: {arrayCreado[i]} ");
            }
            
            Console.WriteLine();

            return arrayCreado;
        }
    }
}
