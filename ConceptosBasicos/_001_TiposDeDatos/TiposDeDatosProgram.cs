using System;

namespace _001_TiposDeDatos
{
    internal class TiposDeDatosProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Tipos de datos numéricos enteros -    Valor minimo / Valor maximo");
            Console.WriteLine();

            // Ejemplo de sbyte
            Console.WriteLine($"Valor de sbyte: Entero con signo de 8 bits.    {sbyte.MinValue} / {sbyte.MaxValue}\r\n");

            // Ejemplo de byte            
            Console.WriteLine($"Valor de byte: Entero sin signo de 8 bits.    {byte.MinValue} / {byte.MaxValue}\r\n");

            // Ejemplo de short            
            Console.WriteLine($"Valor de short: Entero con signo de 16 bits.    {short.MinValue}  /  {short.MaxValue}\r\n");

            // Ejemplo de ushort
            Console.WriteLine($"Valor de ushort: Entero sin signo de 16 bits.    {ushort.MinValue}  /  {ushort.MaxValue}\r\n");

            // Ejemplo de int
            Console.WriteLine($"Valor de int: Entero sin signo de 32 bits.    {int.MinValue}  /  {int.MaxValue}\r\n");

            // Ejemplo de uint
            Console.WriteLine($"Valor de uint: Entero sin signo de 32 bits.    {uint.MinValue}  /  {uint.MaxValue}\r\n");

            // Ejemplo de long
            Console.WriteLine($"Valor de long: Entero con signo de 64 bits.    {long.MinValue}  /  {long.MaxValue}\r\n");

            // Ejemplo de ulong
            Console.WriteLine($"Valor de ulong: Entero sin signo de 64 bits.    {ulong.MinValue}  /  {ulong.MaxValue}\r\n");



            //---------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("\r\n- Tipos de datos numéricos de punto flotante -    Valor minimo / Valor maximo");
            Console.WriteLine();


            // Ejemplo de float
            // float numeroFloat = 3.14f;
            Console.WriteLine($"Valor de float: Número de punto flotante de 32 bits.    {float.MinValue}  /  {float.MaxValue}\r\n");

            // Ejemplo de double
            //double numeroDouble = 1234.5678;
            Console.WriteLine($"Valor de double: Número de punto flotante de 64 bits.    {double.MinValue}  /  {double.MaxValue}\r\n");

            // Ejemplo de decimal
            //decimal numeroDecimal = 12345.6789m;
            Console.WriteLine($"Valor de decimal: Número decimal de 128 bits con precisión fija.    {decimal.MinValue}   /   {decimal.MaxValue}\r\n");



            //---------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("\r\n- Tipos de datos carácter -");
            Console.WriteLine();

            // Ejemplo de carácter
            char caracter = 'A';
            Console.WriteLine($"Carácter: Representa un único carácter Unicode de 16 bits.    {caracter}");



            //---------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("\r\n- Tipos de datos texto -");
            Console.WriteLine();

            // Ejemplo de texto
            string texto = "Hola, ¿cómo estás?";
            Console.WriteLine("Texto: Representa una secuencia de caracteres Unicode.    " + texto);
            


            //---------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("\r\n- Tipos de datos booleano -");
            Console.WriteLine();

            // Ejemplo de booleano
            bool esVerdadero = true;
            Console.WriteLine("Boleano: Representa un valor booleano, que puede ser verdadero (true) o falso (false).  " + esVerdadero);



            //---------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("\r\n- Tipos de datos fecha y hora -");
            Console.WriteLine();


            // Ejemplo de fecha y hora
            DateTime fechaHora = DateTime.Now;
            Console.WriteLine("Fecha y hora: Representa una fecha y hora específica.    " + fechaHora);



            //---------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("\r\n- Tipos de datos enumeración -");
            Console.WriteLine();

            // Ejemplo de enumeración
            EstadoCivil estadoCivil = EstadoCivil.Casado;
            Console.WriteLine("Enumeración: Define un conjunto de constantes con nombre.    " + estadoCivil);

        }

        enum EstadoCivil
        {
            Soltero,
            Casado,
            Divorciado,
            Viudo
        }


        /*

        Tipo de dato objetos genéricos:
        object: Representa cualquier tipo de datos y es la clase base de todos los demás tipos en C#.

        Tipo de dato puntero:
        Las variables puntero en C# están marcadas con el modificador unsafe y se utilizan en contextos no administrados.

        Es importante tener en cuenta que C# es un lenguaje fuertemente tipado, lo que significa que los tipos de datos deben
        ser declarados y son verificados en tiempo de compilación. Además de estos tipos básicos, también puedes crear tus
        propios tipos personalizados utilizando clases, estructuras y enumeraciones.
        
        */

    }
}

