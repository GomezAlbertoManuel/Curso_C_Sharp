using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_SobrecargaDeMetodos
/*
 * La sobrecarga en C# es una característica que permite a una clase tener múltiples métodos con el mismo nombre,
 * pero con diferentes parámetros. Esto significa que puedes definir varias versiones de un método,
 * cada una diseñada para manejar diferentes tipos de datos o cantidades de información.
 * 
 * Cuando llamas a un método sobrecargado, el compilador de C# determina automáticamente cuál versión del método debe ejecutarse
 * según los argumentos que le pases. Es una forma conveniente de ofrecer diferentes funcionalidades bajo un mismo nombre de método,
 * lo que hace que el código sea más limpio y fácil de entender.
 * 
 * Es posible crear cualquier tipo de varieble en los parametros,
 * pero a la hora de llamar al metodo no podemos utilizar parametros  que no esten declarados
 * en alguna de las sobrecargas
 * 
 * Ej: si no tengo nigun metodo declarado sin parametros, no voy a poder llamar al metodo sin parametros "suma()" 
 */

{
    internal class SobrecargaDeMetodosProgram
    {
        //.En el siguiente ejemplo tenemos el metodo "suma" sobrecargado 4 veces con distintos parametros.
        static int suma(int num1, int num2) => num1 + num2;

        static int suma(int num1, int num2, int num3) => num1 + num2 + num3;

        static double suma(double num1, double num2) => num1 + num2;
        
        static double suma(double num1, double num2, double num3) => num1 + num2 + num3;


        static void Main(string[] args)
        {
            //A continuacion llamamos los metodos con los distintos parametros.
            Console.WriteLine(suma(10, 20));

            Console.WriteLine(suma(10, 20, 30));

            Console.WriteLine(suma(10.5, 20.5));

            Console.WriteLine(suma(10.5, 20.5, 30.5));

            //Console.WriteLine(suma());
            //Esta linea de codigo no compila porque no tengo declarado ningún metodo sin parametros.


        }
    }
}
