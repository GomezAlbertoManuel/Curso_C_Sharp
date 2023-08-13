using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Condicional_If
/*
 * Antes de comenzar con es necesario conocer la palabra reservada "bool" 
 * que se utiliza para declarar variables boleanas que solamente devuelven los valores "true" o "false"
 * 
 * .Se declaran de la misma manera que cualquier variable
 *      
 *      bool nombreVariable = false;
 *      bool nombreVariable2 = true;
 * 
 * 
 * los siguientes operadores
 * 
 *  . Operadores de comparación:
 *  
 *  - Igual a(==)
 *  - No igual a(!=)
 *  - Mayor que(>)
 *  - Menor que(<)
 *  - Mayor o igual que(>=)
 *  - Menor o igual que(<=)
 *
 *
 *  . Operadores lógicos:
 *  
 *  - Y lógico(&&)
 *  - O lógico(||)
 *  - Negación lógica(!)
 *  
 *  T
 */
{
    internal class Condicional_IfProgram
    {
        static void Main(string[] args)
        {
            // Utilizando las variables boleanas "valorVerdadero" y "valorFalso vamos a tratar de ejemplificar situaciones de "If"             
            bool valor1 = true;
            bool valor2 = false;
            
            // Igual a (==)
            if (valor1 == true) 
            {
                Console.WriteLine("Si el valor1 ES verdadero, se va a poder leer este texto");            
            }


            // No igual a (!=)
            if (valor2 != true)
            {
                Console.WriteLine("Si el valor2 NO ES, verdadero se va a poder leer este texto");
            }
           

            // Doble negacion "!=" + "!valor"
            if (valor2 != !false)
            {
                Console.WriteLine("\r\nNegar dos veces algo es afirmar.\r\nComo en este caso estoy diciendo -si el valor2 no es no falso " +
                                  "\r\nEsto se traduce a: si el valor2 es falso\r\n");
            }

            Console.WriteLine("Para hacer comparaciones voy a pedirte que ingreses 3 numeros\r\nIngresa el primero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("tercero");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\r\nTengo el primer numero que vale {num1}, el segundo numero que vale {num2} y el tercero que vale {num3}\r\n");

            // Mayor que (>)            
            if (num1 > num2) 
            {
                Console.WriteLine("Si el primer numero es mayor que el segundo se va a leer esto ");
            }
            else
            {

            }

            // Menor que(<)
            if (num1 < num3)
            {
                Console.WriteLine("Si el primer numero es menor que el tercer numero se va a leer esto ");
            }


        }
    }
}
