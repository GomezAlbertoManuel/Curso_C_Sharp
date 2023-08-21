using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    // Declaración de la clase
    public class Persona
    {
        // Campos (atributos)
        private string nombre;
        private int edad;
        private double altura;

        // Constructor por defecto
        public Persona()
        {
        }             

        // Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        

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
