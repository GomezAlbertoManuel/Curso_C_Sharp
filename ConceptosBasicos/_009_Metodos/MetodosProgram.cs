using System;
using System.Runtime.InteropServices;

namespace _009_Metodos
/* En C#, un método es un bloque de código que realiza una tarea específica.
 * Piensa en los métodos como pequeñas acciones que puedes pedirle a tu programa que realice.
 * Cada método tiene un nombre que lo identifica y puede recibir datos, llamados parámetros, para trabajar con ellos.
 * Un método en C# generalmente se compone de tres partes:
 * 
 * . Nombre del método: Es el identificador único del método y se utiliza para llamarlo cuando queremos que se ejecute.
 * 
 * . Parámetros: Son valores que pueden ser enviados al método para que lo utilice en su funcionamiento.
 *              Los métodos pueden tener cero, uno o varios parámetros.
 * 
 * . Cuerpo del método: Aquí es donde se escribe el código que realiza la tarea deseada.
 *                     Cuando llamamos al método, el programa ejecuta este código.
 *      
 *      
 *  ---------------------------------------------------------------------------------------------
 *  
 *          Declaración de metodos (sintaxis)
 *
 *   |---------------------------------------------|
 *   |                                             |
 *   |   tipodevuelto NombreMetodo (parámetros)    |
 *   |   {                                         |
 *   |       Cuerpo del método                     |
 *   |   }                                         |
 *   |                                             |
 *   |---------------------------------------------|
 *               Convención "PascalCasing"
 *  
 *  
 *  .Los parametros no son obligatorios, pero los parentsis si.
 *  
 *  .Los metodos que retornan valor SIEMPRE deben terminar con la palabra reservada "return" seguida del valor a devolver.
 *   Tecnicamente hablando, el valor a devolver puede ser cualquier cosa, pero no seria logico crear un metodo para calcular
 *   la suma de "a + b + c", pero que  me devuelva "a"
 *       
 *  .Anteponiendo la palabra reservada "void" al nombre del metodo, indicamos que el metodo no devuelve ningun valor.
 *   Un metodo que no retorna valor puede ESCRIBIR el texto "25" en pantalla, pero ese "25" no sirve para hacer calculos.
 *   En cambio un metodo que si retorna valor, nos RETORNA el valor "25" y este valor si puede ser usado para hacer calculos.
 *
 */

{
    internal class MetodosProgram
    {        
        static void Main(string[] args)
        {
            //Metodos sin parametros con valor de retorno (return)
            double PerimetroRectangulo()
            {
                double alto = 10;
                double ancho = 20;

                double perimetro = alto * 2 + ancho * 2;

                return perimetro;                
            }

            double AreaRectangulo()
            {

                Console.WriteLine("Por favor ingrese la base del rectangulo");
                double baseR = double.Parse(Console.ReadLine());

                Console.WriteLine("Por favor ingrese la altura del rectangulo");
                double alturaR = double.Parse(Console.ReadLine());

                double areaR = (baseR * alturaR);
                Console.WriteLine($"El area es: {areaR} \r\n");
                return areaR;
            }

            Console.WriteLine("Aquí se calcula el perimetro de un rectangulo de 10 de alto x 20 de ancho");
            Console.WriteLine($"Da como resultado {PerimetroRectangulo()} \r\n");

            Console.WriteLine("Y ahora, con su ayuda, vamos a calcular el area de este u otro rectangulo \r\n");

            AreaRectangulo();
            Console.WriteLine("\r\n");



            //Metodos con parametros con valor de retorno (return)
            double AreaTriangulo(double baseT, double alturaT)
            {
                double areaT = (baseT * alturaT) / 2;
                return areaT;
            }


            // TIP: Cuando el metodo lo podemos resumir a una sola  linea de codigos, podemos abreviarlo "=>"
            double perimetroTriangulo(double a, double b, double c) => a + b + c;
            
                        
            Console.WriteLine("A continuacion se calcula el area de un triangulo con una base de 35 y una altura de 30. ");
            Console.WriteLine($"Da como resultado: {AreaTriangulo(25, 30)} \r\n");

            Console.WriteLine("Una vez mas, con su ayuda calcularemos el perimetro de un tringulo.\r\n");

            Console.WriteLine("Ingrese la medida del primer lado del triangulo");
            double ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la medida del segundo lado del triangulo");
            double ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la medida del tercer lado del triangulo");
            double ladoC = double.Parse(Console.ReadLine());

            double perimetroT = perimetroTriangulo(ladoA, ladoB, ladoC);
            Console.WriteLine($"El perimetro del triangulo es: {perimetroT}");


            /* Hasta este punto del codigo hemos usado metodos que estan dentro del "Main"
             * le dimos su tipo, nombre, parametros y cuerpo.
             * pero los metodos suelen usarse dentro de una clase, no dentro del metodo "Main"
             */


            //------------------------------------------------------------------------------------------------------------------
            // A continuacion utilizaremos metodos que estan fuera del "Main", pero dentro de la clase "MetodosProgram"

            Explicacion();

            Suma(25, 30);




        }


        //Metodo sin parametros sin valor de retorno (void)
        static void Explicacion ()
        {
            Console.WriteLine("\r\nA continuacion utilizaremos metodos que estan fuera del \"Main\", pero dentro de la clase \"MetodosProgram\" \r\n" +
                "Para que el metodo no retorne valor hay que anteponer la palabra reservada \"void\" \r\n" +
                "y para que el metodo pueda ser llamado desde el \"Main\", hay que anteponer la palabra reservada \"static\" \r\n");
        }



        // Método con parámetros sin valor de retorno
        static void Suma(int parametro1, int parametro2)
        {
            Console.WriteLine($"¿Por qué si esto es un metodo que no retorna valor, igualmente puedo ver el resultado de una suma?\r\n" +
                $"Ejemplo: 25 + 30 = {parametro1 + parametro2}");
        }
        

    }
    }
