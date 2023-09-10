using System;


namespace _000_Convenciones
{
    internal class ConvencionesProgram
    {
     
        // 1. PascalCase: Se utiliza para nombrar tipos y miembros públicos.
        // Comienza con una letra mayúscula y utiliza mayúsculas para separar palabras por ejemplo, MiClase o MiMetodoPublico.

        // 2. camelCase: Se usa para nombrar variables y parámetros. Comienza con una letra minúscula y utiliza mayúsculas para separar palabras, por ejemplo, miVariable o miParametro.

        // 3. UPPER_CASE: Se emplea para nombrar constantes. Todas las letras están en mayúsculas y las palabras se separan con guiones bajos, por ejemplo, MI_CONSTANTE.

        // 4. _underscore: A menudo se usa como prefijo en nombres de campos privados, por ejemplo, _miCampoPrivado.

        // 5. IInterface: Las interfaces suelen comenzar con "I" mayúscula, por ejemplo, IPersona para una interfaz que define métodos y propiedades relacionadas con personas.

        // 6. Eventos: Los eventos suelen tener nombres que terminan con "EventHandler", por ejemplo, ClickEventHandler para un evento relacionado con clics.

        // 7. Delegate Naming: Los delegados (delegates) suelen tener nombres que terminan con "Delegate", por ejemplo, ActionDelegate para un delegado que representa una acción.

        // 8. Propiedades Auto-implementadas: Para propiedades simples, puedes utilizar una convención más corta donde no necesitas declarar un campo explícito. Por ejemplo:
        //    public int MiPropiedad { get; set; }

        // 9. Nombres de Espacios de Nombres (Namespaces): Suelen seguir una estructura inversa de dominio, por ejemplo, MiCompania.MiProducto.SubProducto.

        // 10. Sufijos para Tipos Genéricos: A veces, se añaden sufijos a los nombres de tipos genéricos para indicar su propósito, como List<T> para una lista genérica.

        // 11. Convención de parámetros de métodos: Los parámetros de método deben ser descriptivos y concisos, indicando su función, por ejemplo, int suma(int a, int b).

        // 12. Convención de retorno de métodos: Los nombres de métodos deben indicar lo que hacen y, si es relevante, lo que devuelven, por ejemplo, int ObtenerNumero().

        // Estas convenciones ayudan a que el código sea más legible y consistente, lo que facilita su mantenimiento y comprensión por parte de otros programadores. Es importante seguir estas convenciones para escribir un código C# limpio y comprensible.

        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
        }
    }
}
