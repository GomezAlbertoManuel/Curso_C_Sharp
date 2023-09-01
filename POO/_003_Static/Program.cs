using System;

namespace _003_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso de constante de la clase "EjEstatico"
            // esta siempre vale "25" y no puede ser modificada porque es constante.
            Console.WriteLine(EjEstatico.constanteDePrueba);

            // Uso de variable estatica de la clase "EjEstatico"
            // el valor de esta variable solo puede ser modificada desde la clase a la que pertenece
            Console.WriteLine(EjEstatico.contadorPublico);

            // Uso de metodo estatico de la clase "EjEstatico       
            Console.WriteLine(EjEstatico.Contador());

            /* TANTO LOS METODOS ESTATICOS, COMO LAS CONSTANTES Y LAS VARIABLES ESTATICAS
             * PERTENECEN A LA CLASE Y NO A LAS INSTANCIAS.
             * 
             * POR DEDUCCION PODEMOS DECIR QUE "WriteLine" ES UN METODO ESTATICO QUE PERTENECE A LA CLACE "Console"
             * POR LA MANERA QUE ACCEDEMOS A EL.
             * 
             */



            // El siguiente codigo  realiza prueba del metodo contador.
            // Da como resultado "4" ya que el constructor con dos variables no tiene contador.

            EjEstatico primeraInstancia = new EjEstatico(); //Suma
            EjEstatico segundaInstancia = new EjEstatico(1); //Suma
            EjEstatico terceraInstancia = new EjEstatico(20, 2.5); //No Suma
            EjEstatico cuartaInstancia = new EjEstatico(); //Suma
            EjEstatico quintaInstancia = new EjEstatico(2); //Suma
            EjEstatico sextaInstancia = new EjEstatico(30, 5.5); //No Suma

            Console.WriteLine(EjEstatico.Contador());


        }
    }
}
