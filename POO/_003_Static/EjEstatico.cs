using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Static
{
    internal class EjEstatico
    {
        /* En C#, la palabra clave "static" se utiliza para declarar miembros de una clase
         * que pertenecen a la clase en sí misma en lugar de pertenecer a instancias individuales de la clase.
         *
         * "En C#, 'static' es una palabra clave que se utiliza para declarar miembros de una clase
         * que son compartidos por todas las instancias de esa clase en lugar de pertenecer a una instancia específica.
         * Los miembros estáticos se asocian con la clase en sí y no requieren que se cree una instancia de la clase para acceder a ellos.
         * Esto significa que los miembros estáticos se pueden utilizar a través del nombre de la clase en lugar de a través de una instancia particular,
         * lo que los hace útiles para definir constantes, métodos de utilidad y propiedades compartidas entre todas las instancias de la clase." */




        // La variable contador es una variable de clase "static" y solo puede ser modificada por la clase a la que pertenece (en este caso "EjEstatico")
        // Si la declarara como publica esta podria ser accesible directamente por el nombre de esta clase y punto "." sin necesidad de crear una instancia.
        // Ej: "EjEstatico.contador"
        public static int contadorPublico = 0;
        private static int contador = 0;
        private int variableDePrueba = 0;
        private double variableDePrueba2 = 0;



        // NOTA: LAS VARIABLES CONSTANTES DE UNA CLASE, C# LAS ASUME COMO ESTATICAS.
        // A continuacion declaro una constante solo para demostrar que es tratada como si fuera una variable estatica.
        // esta es accesible directamente por el nombre de esta clase y punto "." sin necesidad de crear una instancia.
        // Ej: "EjEstatico.constanciadePrueba"
        public const int constanteDePrueba = 25;



        // Esto en un construcor por defecto creado con el unico fin de darle una utilidad al contador.
        // cada vez que se cree una instancia del objeto "EjEstatico" se va a sumar 1 al contador.
        public EjEstatico()
        {
            contador++;
        }


        // Aqui estoy creano otro constructor para seguir sumando al contador cada vez que creo una instancia del objeto "EjEstatico"
        // Para que sume en todos los caso que se cree una instancia de este objeto, habria que agregar "contador++" a todos los constructores.
        // En el caso que no quisiera sumar, simplemente no le agrego la variable "contador++" al constructor.
        public EjEstatico(int variableDePrueba)
        {
            this.variableDePrueba = variableDePrueba;

            contador++;
        }

        // Este constructor no suma nada al contador cada vez que se cree una instancia.
        public EjEstatico(int variableDePrueba, double variableDePrueba2)
        {
            this.variableDePrueba = variableDePrueba;
            this.variableDePrueba2 = variableDePrueba;
        }

        // Aqui estoy creando un metodo para acceder a la variable de clase "contador".
        // la variable esta en minuscula y el metodo comienza en Mayuscula.
        // El metodo es accesible desde otras clases mientras que la variable no.
        // El metodo podria no ser "static", pero en este caso no tiene sentido
        // por que no necesitamos realizar ninguna modificacion en el metodo.
        public static int Contador() => contador;




        // Copiar el siguiente codigo en el metodo "Main" para realizar prueba del contador.
        // Da como resultado "4" ya que el constructor con dos variables no tiene contador.

        /*
         
            EjEstatico primeraInstancia = new EjEstatico(); //Suma
            EjEstatico segundaInstancia = new EjEstatico(1); //Suma
            EjEstatico terceraInstancia = new EjEstatico(20, 2.5); //No Suma
            EjEstatico cuartaInstancia = new EjEstatico(); //Suma
            EjEstatico quintaInstancia = new EjEstatico(2); //Suma
            EjEstatico sextaInstancia = new EjEstatico(30, 5.5); //No Suma

            Console.WriteLine(EjEstatico.Contador());

        */

    }
}
