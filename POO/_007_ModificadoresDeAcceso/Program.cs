using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ModificadoresDeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        // Los modificadores de acceso en C# controlan la visibilidad y el alcance de los miembros de una clase.
        // Estos modificadores determinan quién puede acceder a un miembro y desde dónde se puede acceder.
        // Los principales modificadores de acceso incluyen:


        
        // -  p u b l i c  -

        // El modificador de acceso 'public' permite que un miembro de una clase sea accesible
        // desde cualquier lugaren el código, tanto desde dentro de la clase que lo define como desde fuera de ella.

        // Ejemplo de un campo público:
        public class MiClase
        {
            // Este campo es público y puede ser accedido desde cualquier parte del código.
            public int campoPublico = 10;
        }




        // -  p r i v a t e  -

        // El modificador de acceso 'private' limita la visibilidad de un miembro de una clase
        // únicamente a la propia clase en la que se define.
        // A esto se lo conoce como encapulamiento.
        public class MiClase2
        {
            // Este campo es privado y solo puede ser accesible desde la misma clase,
            // o desde otras, pero a traves de n metodo publico
            private int campoPrivado = 26;
            
            public void Metodopublico()
            {
                int accesoACampoPrivado = campoPrivado;
            }           
        }




        // - p r o t e c t e d  -

        // El modificador de acceso 'protected' permite que un miembro de una clase sea accesible
        // desde la propia clase que lo define y desde clases derivadas (heredadas) de la misma,
        // pero no desde fuera de ellas.

        // Ejemplo de un campo protegido:
        public class ClaseBase
        {
            // Este campo es protegido y puede ser accedido desde la propia clase y sus clases derivadas.
            protected int campoProtegido = 20;
        }

        public class ClaseDerivada : ClaseBase
        {
            // Desde la clase derivada, podemos acceder al campo protegido de la clase base.
            public void Metodo()
            {
                int valor = campoProtegido; // Acceso permitido al campo protegido.               
            }
        }




        // - O t r o s   m o d i f i c a d o r e s

        // - internal: Limita el acceso al ensamblado actual.
        // - protected internal: Combina las características de protected e internal.
        // - private protected: Permite el acceso solo a clases derivadas en el mismo ensamblado.



    }
}
