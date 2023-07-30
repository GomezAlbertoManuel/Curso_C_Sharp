using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_OperadoresDeComparacion
{
    internal class OperadoresDeComparacionProgram
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            int c = 5;

            // Operador Menor que "<"
            bool menorQue = a < b;
            Console.WriteLine($"Es {a} menor que {b}? {menorQue}");

            // Operador Mayor que ">"
            bool mayorQue = a > b;
            Console.WriteLine($"Es {a} mayor que {b}? {mayorQue}");

            // Operador Menor o igual que "<="
            bool menorOIgualQue = a <= c;
            Console.WriteLine($"Es {a} menor o igual que {c}? {menorOIgualQue}");

            // Operador Mayor o igual que ">="
            bool mayorOIgualQue = b >= c;
            Console.WriteLine($"Es {b} mayor o igual que {c}? {mayorOIgualQue}");

            // Operador Igual a "="
            bool igualQue = a == c;
            Console.WriteLine($"Es {a} igual a {c}? {igualQue}");

            // Operador Distinto de "!="
            bool distintoQue = a != b;
            Console.WriteLine($"Es {a} distinto de {b}? {distintoQue}");



            /*El operador "==" en C# se utiliza para realizar una comparación de igualdad entre dos valores. 
             *Este operador compara los valores de dos expresiones y devuelve un valor booleano (verdadero o falso)
             *que indica si ambas expresiones son iguales.
             *Es importante tener en cuenta que el operador "==" se diferencia del operador de asignación "=" en C#. 
             *Mientras que "==" se utiliza para comparar valores, "=" se utiliza para asignar un valor a una variable.
             */

            int numero1 = 5;
            int numero2 = 10;

            // Comparación de igualdad con el operador "=="
            bool sonIguales = numero1 == numero2;

            Console.WriteLine($"¿El número {numero1} es igual a {numero2}? {sonIguales}");
        

    }
    }
}
