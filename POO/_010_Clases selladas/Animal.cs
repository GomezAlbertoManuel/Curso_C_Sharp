using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Clases_selladas
{
    abstract class Animal
    {
        // Campos
        private string tipoAnimal;
        private string nombre;
        

        // Constructores
        public Animal(string tipoAnimal, string nombre = "No especifica") 
        {
            this.tipoAnimal = tipoAnimal;
            this.nombre = nombre;
        }      
        

        // Propiedades
        public string TipoAnimal
        {
            get { return tipoAnimal; }
            set { tipoAnimal = value; }
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // Metodos
        public abstract void Pensar();
    }
}
