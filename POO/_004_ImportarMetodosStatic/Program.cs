using System;

// Hay casos en el que uno puede necesitar usar metodos estaticos de una clase de manera masiva.
// En esos casos a veces conviene importar todos los metodos estaticos de esa clase y, de esa manera,
// podemos acceder a los metodos sin tener que estar escribiendo el nombre de la clase continuamente.
// Por ejemplo: si necesitaramos utilizar metodos de la clase "Console" se hace de la siguiente manera.
using static System.Console;

// Tambien podemos acceder a los metodos estaticos de nuestras propias clases de la misma manera.
using static _004_ImportarMetodosStatic.Matematicas;


namespace _004_ImportarMetodosStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ahora puedo prescindir de escribir el nombre de la clase "Console" de la biblioteca "System"
            // para acceder a los metodos estaticos de la misma.
            WriteLine("  Escribe tu nombre");
            string nombre = ReadLine();
            WriteLine($"  Gracias {nombre}, esto sirve para demostrar que funcionan los metodos");
            WriteLine("\r\n  Ahora necesito que escribas un numero");
            int numero1 = int.Parse(ReadLine());
            WriteLine("  Y un numero mas, por favor.");
            int numero2 = int.Parse(ReadLine());
            WriteLine($"  Estos numeros son para probar mi metodo \"Multiplicar\" de mi clase \"Matematicas\"");

            // Tambien puedo hacer lo mismo con los metodos de mi clase "Matematicas"
            // En la siguiente linea accedo al metodo "Multiplicar" de la Clase "Matematicas" sin el nombre de la clase.
            WriteLine($"\r\n  El resultado es: {Multiplicar(numero1, numero2)}\r\n");            
            
        }
    }
}
