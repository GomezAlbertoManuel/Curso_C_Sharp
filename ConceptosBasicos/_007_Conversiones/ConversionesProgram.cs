using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Conversiones
{
    internal class ConversionesProgram
    {
        static void Main(string[] args)
        {

            //.Conversion explícita (Casting)
            double temperatura = 34.5;
            int temperaturaBuenosAires = (int)temperatura;
            Console.WriteLine($"La temperatura de Madrid es: {temperaturaBuenosAires}");


            //.Conversión implícita
            int habitantesCiudad = 100000000;
            long habitantesCiudad2018 = habitantesCiudad;

            Console.WriteLine($"los habitante de la ciudad de buenos aires son: {habitantesCiudad2018}");

            float pesoMaterial = 5.78f;
            double pesomaterialpreciso = pesoMaterial;

            Console.WriteLine($"El peso del material es {pesomaterialpreciso}");

            /*Para mas información buscar "tabla de conversiones numericas implicitas/explicitas"
             *link de microsoft: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/numeric-conversions
             */


            //.Convertir texto número (Parse)
            string texto = "123";
            int conversion = int.Parse(texto);

            Console.WriteLine(conversion); // Salida: 123


            Console.WriteLine("Introduce el primer número");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");

            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;

            Console.WriteLine($"La suma de esos dos numeros es: {resultado}");


            // Uso de TryParse (creado por ChatGPT)
            string input = "123";
            
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("La conversión fue exitosa: " + result);
            }
            else
            {
                Console.WriteLine("No se pudo convertir la cadena en un número entero.");
            }

            /*Es recomendable asegurarse de que la cadena sea válida antes de utilizar Parse o TryParse 
             * para evitar excepciones innecesarias
             */ 

        }
    }
}
