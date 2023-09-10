using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Arrays
{
    internal class Parientes
    {
        public string apodo;
        private string nombre;
        private int edad;

        public Parientes(string nombre, int edad, string apodo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.apodo = apodo;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int getEdad() 
        {
            return edad;
        }

        public void setNombre (string nombre) => this.nombre = nombre;
        public void setEdad (int edad) => this.edad = edad;
        
        public void Info() { }

    }
}
