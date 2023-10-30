using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Properties
{
    internal class PropertiesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" +
                "En C#, las propiedades son miembros de una clase que permiten el acceso y la modificación de los " +
                "atributos o campos privados de la clase de una manera controlada.\r\n\r\n" +
                "Las propiedades proporcionan una forma de encapsular el acceso a los campos privados de una clase, " +
                "lo que significa que puedes definir cómo se obtiene y establece el valor de un atributo sin exponer" +
                "directamente el campo subyacente.\r\n\r\n" +
                "Una propiedad consta de dos bloques: el 'get' (obtención) y el 'set' (establecimiento). El bloque 'get'" +
                "define cómo se recupera el valor de la propiedad, y el bloque 'set' define cómo se asigna un valor a la" +
                "propiedad.\r\n\r\n" +
                "Por ejemplo, si tienes una clase con un campo 'edad', puedes definir una propiedad 'Edad' que permita" +
                "obtener y establecer la edad de un objeto de la siguiente manera:\r\n" +
                "public int Edad\r\n" +
                "{\r\n" +
                "    get { return edad; } // Obtener el valor del campo 'edad'\r\n" +
                "    set { edad = value; } // Establecer el valor del campo 'edad'\r\n" +
                "}\r\n\r\n" +
                "Cuando trabajas con propiedades, puedes agregar lógica personalizada en los bloques 'get' y 'set' para" +
                "realizar validaciones, cálculos u otras operaciones necesarias. Además, las propiedades permiten controlar" +
                "quiénes y cómo acceden a los campos de la clase, ya que puedes establecer diferentes niveles de acceso," +
                "como público, privado o protegido.\r\n\r\n" +
                "En resumen, las propiedades en C# son una forma eficaz de proporcionar acceso a los atributos de una clase" +
                "mientras se mantiene el control sobre cómo se obtiene y establece el valor, lo que favorece la encapsulación" +
                "y la seguridad de los datos.");



            Console.WriteLine("__________________________________________________\r\n \r\n");

            Empleado empleado = new Empleado("Manuel");

            Console.WriteLine($"Hola ingresa el nuevo salario para: {empleado.Nombre}");

            empleado.Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa una contraseña, para asignar a " + empleado.Nombre);

            empleado.Contraseña = Console.ReadLine();
                                 

            Console.WriteLine("No se definio apellido para: " + empleado.Nombre  + "\r\n" +
                "Por favor, escriba el apellido");

            empleado.Apelido = Console.ReadLine();
            Console.WriteLine($"\r\nSe ha creado el empleado {empleado.Nombre} {empleado.Apelido}. \r\nSu Salario Inicial es: ${empleado.Salario}");

            
        }
    }
}
