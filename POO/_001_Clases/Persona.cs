using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Clases

{   // Declaración de la clase
    internal class Persona
    {
            // Campos (atributos)
            private string nombre;
            private int edad;
            private double altura;


            // Constructor por defecto        
            public Persona()
            {
            }
            /* El constructor por defecto no es necesario crearlo.
             * C# asume que existe, aunque no este hecho. 
             */

        
            // Sobrecarga de constructor
            public Persona(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
            // En el caso que no exista un constructor sin parametros, este seria el construcyor por defecto


            // Propiedades
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public int Edad
            {
                get { return edad; }
                set { edad = value; }
            }

            public double Altura { get => altura; set => altura = value; }

            // Método de instancia
            public void Presentarse()
            {
                Console.WriteLine($"Hola, soy {nombre} y tengo {edad} años.");
            }
        }
}
