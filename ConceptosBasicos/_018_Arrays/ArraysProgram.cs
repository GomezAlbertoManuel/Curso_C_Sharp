using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Arrays
{
    internal class ArraysProgram
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
            Console.WriteLine(numPares[0] + "  Primer elemento de \"numPares\""); // Accede al primer elemento de "numPares" y lo imprime en pantalla.
            int primerNumImpar = numImpares[0]; // Accede al primer elemento de "numImpares".
            Console.WriteLine(primerNumImpar + "  Primer elemento de \"numImpares\""); // Aquí imprimo el primer elemento de "numImpares" accedido desde la variable "primerNumImpar"


            // Longitud del Array:
            Console.WriteLine(numPares.Length + "  Longitud del array \"numPares\"");// Obtiene la longitud del array "numPares".
            int longitudNumImpares = numImpares.Length;// Obtiene la longitud del array "numImpares".
            Console.WriteLine(longitudNumImpares + "  Longitud del array \"numImpares\"");

            Console.WriteLine("\r\n \r\n");
            Console.Write("Bucle \"for\" numeros primos: ");

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

            Console.WriteLine("\r\n \r\n \r\nBucle \"for\" arrays implicitos:");
            for (int i = 0; i < nombre.Length; i++) 
            {
                Console.WriteLine($"\r\nEn la posicion {i} se encuentra {nombre[i]}\r\nQue tiene {edad[i]} años y mide {altura[i]}\r\n \r\n" );
            }


            //--------------------------------------------------------------------------------------------------------------------

            // Arrays de objetos

            // Declaracion del array
            Parientes[] pariente = new Parientes[2] ;

            // hay dos opciones para ingresar datos de los objetos en el array

            // Opcion 1: Construir el objeto mientras lo almacenamos en el array.
            pariente[0] = new Parientes("Gabriela", 43, "La Gabi");


            // Opcion 2: Crear el objeto...
            Parientes gustavo = new Parientes("Gustavo", 32, "Gusti");

            // y luego almacenarlo en el array
            pariente[1] = gustavo;

            Console.WriteLine($"Acceso al objeto del array [0]: {pariente[0]}");
            Console.WriteLine($"Acceso a informacion especifica del array [0]:  Nombre: {pariente[0].getNombre()}  Edad: {pariente[0].getEdad()}  " +
                              $"Apodo: {pariente[0].apodo}\r\n \r\n");

            // * Curiosidad: los arrays implicitos tambien admite objetos.
            Parientes andrea = new Parientes("Yesica", 36, "La Murci");

            var arraysObjetos = new[] { gustavo, andrea};

           


            // De igual manera podemos crear arrays de tipo o clases anonimas
            var arraysClasesAnonima = new[]
            {
                // Al igual que todos los arrays, las matrices se separan con coma ","
                // Cada clase declarada debe tener los mismos tipos de variable, con el mismo nombre y la misma estructura.
                new{ nombre = "Juan", edad = 25 },

                new { nombre = "Jose", edad = 30 },

                new { nombre = "Pedro", edad = 45 },
                
              //new { edad = 45, nombre = "Lucia"}
                              
                // La clase anonima "Lucia", aunque tiene las mismas variables, no compila
                // porque no respeta el orden de las variables.

            };  // NO OLVIDAR CERRAR EL ARRAY CON PUNTO Y COMA ";"

            Console.WriteLine("Acceso al array [1] de clase anonima: " + arraysClasesAnonima[1]);

            // Tambien podemos acceder a datos especificos de la clase anonima
            Console.WriteLine("Acceso a datos especificos del array [1] de clase anonima:  " +
                               "nombre: " + arraysClasesAnonima[1].nombre + "  " +
                               "edad: " + arraysClasesAnonima[1].edad + "\r\n \r\n");

            Console.WriteLine("Acceso a todos los objetos de la clase anonima: ");
            for (int i = 0;i < arraysClasesAnonima.Length; i++) 
            {
                Console.WriteLine($"Nombre: {arraysClasesAnonima[i].nombre}  Edad: {arraysClasesAnonima[1].edad}");
            }


            // Modificación de datos De los arrays
            Console.WriteLine("\r\n \r\nModificación de datos De los arrays:\r\n");

            Console.WriteLine($"Apodo original (variable publica): {pariente[1].apodo}\r\n");

            // Las variables publicas pueden ser modificadas de manera directa
            pariente[1].apodo = "Coco";
            Console.WriteLine($"Nuevo apodo: {pariente[1].apodo}\r\n");

            Console.WriteLine($"Nombre original (variable privada): {pariente[1].getNombre()}");

            // Las variables privadas se modifican a travez de metodos
            pariente[1].setNombre("Gabriel");

            Console.WriteLine($"Nuevo nombre: {pariente[1].getNombre()}\r\n");
            
            
            
            // Las clases anonimas no pueden ser modificadas una vez creadas,
            // por tal motivo la siguiente linea de codigo genera error.

            // arraysClasesAnonima[0].nombre = "Juan Carlos";


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
}
