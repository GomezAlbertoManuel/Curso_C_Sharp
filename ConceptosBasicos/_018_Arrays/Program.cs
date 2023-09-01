using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de un Array:            
             int[] numPares;


            // Inicialización de un Array
            // [Entre corchetes va la cantidad de valores que va a guardar el array]:   
            numPares = new int[5]; 


            // Asignación de Valores:
            // [Entre corchetes el numero de la matriz a la que asignamos el valor]
            // *LA MATRIZ SIEMPRE INICIA DESDE "0" (CERO)
            numPares[0] = 2;
            numPares[1] = 4;
            numPares[2] = 6;
            numPares[3] = 8;
            numPares[4] = 10;


            // Podemos declarar, iniciar y asignar valor en una sola linea,
            // pero en este caso hay que rellenar el total de las matrices.
            int[] numImpares = new int[6] {1, 3, 5, 7, 9, 11};

            // Por eso en los casos que ya sabemos cuales son los valores que vamos a asignar 
            // conviene la inicializacion simplificada en una sola linea
            // ya que de esta manera no es necesario declarar la cantidad de valores que vamos a utilizar.
            int[] numPrimos = { 2, 3, 5, 7, 11, 13, 17, 19 };
            
            // Acceso a los Elementos:
            Console.WriteLine(numPares[0]); // Accede al primer elemento de "numPares" y lo imprime en pantalla.
            int primerNumImpar = numImpares[0]; // Accede al primer elemento de "numImpares".
            Console.WriteLine(primerNumImpar); // Aquí imprimo el primer elemento de "numImpares" accedido desde la variable "primerNumImpar"


            // Longitud del Array:
            Console.WriteLine(numPares.Length);// Obtiene la longitud del array "numPares".
            int longitudNumImpares = numImpares.Length;// Obtiene la longitud del array "numImpares".
            Console.WriteLine(longitudNumImpares);

            Console.WriteLine("\r\n \r\n");
            Console.Write("Numeros primos: ");

            // Recorrido de un Array:
            // El indice "i" nos indica en que posicion del array nos encontramos
            // El nombre del array + ".Length" nos indica el amaño del array
            // Por ultimo accedemos a cada una de las matrices utilizando el numero de indice.
            for (int i = 0; i < numPrimos.Length; i++)
            {
                Console.Write(numPrimos[i] + ", ");
            }



            //--------------------------------------------------------------------------------------------------------------------

            // Arrays Implicitos
            // En los arrays implicitos no es necesario declarar ni el tipo de datos, el tamaño del array.
            // C# asigna automaticamente el tipo de datos en funcion a los datos ingresado.
            var nombre = new[] { "Manuel", "Silvia", "Luciano", "Lucas", "Onna" };
            var edad = new[] { 41, 36, 15, 11, 5 };
            var altura = new[] { 1.7, 1.55, 1.50, 1.3, 1.1 };

            for (int i = 0; i < nombre.Length; i++) 
            {
                Console.WriteLine($"\r\n \r\nEn la posicion {i} se encuentra {nombre[i]}\r\nQue tiene {edad[i]} años y mide {altura[i]}\r\n" );
            }



            //--------------------------------------------------------------------------------------------------------------------

            // Arrays Multidimensionales:

            // Un array multidimensional es una estructura que permite almacenar elementos en una matriz o tabla
            // con más de una dimensión. Esto permite organizar datos en filas y columnas (u otras dimensiones adicionales),
            // creando estructuras de datos más complejas. Accedes a estos arrays utilizando índices que especifican su
            // ubicación en cada dimensión. Por ejemplo, en una matriz bidimensional, se utiliza un índice para la fila
            // y otro para la columna para acceder a un elemento específico.

            int[,] matriz = new int[2, 2];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            //...

        }
    }

    class Primos
    {
        string nombre;
        int edad;

        public Primos(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

        }
    }
}
