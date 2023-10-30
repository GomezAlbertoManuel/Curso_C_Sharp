using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Properties
{
    internal class Empleado
    {
        private string nombre;
        private string apellido;
        private double salario;
        private string contraseña;
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        // El metodo "IngresarSalario" es "private" porque solo va a ser usado por la propiedad set de "Salario"
        // no es necesario hacerlo publico.
        private double IngresarSalario(double nuevoSalario)
        {
            while (nuevoSalario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo.\r\n \r\n Ingrese nuevo salario:");
                nuevoSalario = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("El nuevo salario asignado es: $" + nuevoSalario);
            return this.salario = nuevoSalario;
        }

        // La convención general para nombrar propiedades es utilizar el formato "PascalCase"
        // El "get" no tiene mucha ciencia, solo devuelve el valor que le asignemos
        // Pero el "set" nos da la ventaja que podemos asignar un metodo para validar el valor ingresado.
        public double Salario 
        {            
            get { return salario; }            
            set { salario = IngresarSalario(value); }
        }


        // Las propiedades pueden ser de solo lectura.
        // en este caso accedemos al nombre ingresado en el constructor.
        public string Nombre 
        {
            get { return nombre; }
        }

        // Tambien pueden ser de solo escritura, como en el caso de las contraseñas. 
        public string Contraseña 
        {
            set { contraseña = ValidarContraseña(value); }
        }

        private string ValidarContraseña (string contraseña)
        {
            String texto = "Contraseña Asignada";

            return texto;
        }


        // -------------------------------------------------------------------------------------------
        // Declaracion simplificada (expression bodied)
        public double Salario2 
        {
            get => salario;
            set => salario = IngresarSalario(value);
        }



        // -------------------------------------------------------------------------------------------
        // Propiedad atomatica
        // Puedes acceder y modificar el valor de esta propiedad como si fuera un campo público,
        // pero en realidad, está respaldado por un campo privado y el compilador se encarga de generar los métodos get y set necesarios.
        public string Apelido { get; set; }

    }
}
