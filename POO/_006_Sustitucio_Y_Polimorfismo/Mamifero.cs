using System;

namespace _005_Herencia
{
    // Mamifero en este caso hace de "Superclase"
    internal class Mamifero
    {
        public string nombre;  

        
        public Mamifero(string nombre)
        {
            Console.WriteLine($"Ha creado un Mamifero de nombre {nombre}");
            this.nombre = nombre;
        }
    
        public void Respirar()
        {
            Console.WriteLine($"Soy {nombre} estoy respirando") ;
        }

        public void Respirar(bool despacio) 
        {
            if ( despacio ) { Console.WriteLine("Inhalo 1, 2, 3 ... Exhalo... Inhalo 1, 2, 3 ... Exhalo");}
            else { Console.WriteLine("Inhalo, Exhalo. Inhalo, Exhalo"); }
        }

        public void Respirar(bool contener, int segundos) 
        {
            if ( contener ) 
            {
                if (segundos > 120)
                { Console.WriteLine($"{segundos} Segundos. Guau este mamifero aguanta mucho sin respirar"); }
                else { Console.WriteLine($"{segundos} Segundos. Este mamifero no soportaria mucho debajo del agua"); }
            }
            else Respirar();
        }

        public void CuidarCria()
        {
            Console.WriteLine($"Soy {nombre} Cuido de mis crias hasta que se valgan por si solas");
        }

        public void Pensar() 
        {
            Console.WriteLine($"Soy {nombre} tengo pensamiento basico instintivo");
        }

        public virtual void Desplazar() 
        { Console.WriteLine($"soy {nombre} Puedo desplazarme \r\n"); }


        // Metodo "Static" se puede acceder direcamente de la clase.
        // NO SE PUEDE DECLARAR VIRTUAL A UN METODO ESTATICO
        public static void Info() 
        {
            Console.WriteLine("Los mamíferos son animales vertebrados que se caracterizan por tener glándulas mamarias \r\nque les permiten alimentar a sus crías con leche materna.\r\nAdemás, suelen tener pelo o piel, y la mayoría de ellos son de sangre caliente.\r\n");
        }
    }
}
