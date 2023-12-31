﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
    internal class HerenciaProgram
    {
        // Al utilizar clases que heredan de otras, podemos utilizar las propiedades y metodos heredadas de las mismas.

        static void Main(string[] args)
        {   
            // C O N S T R U C T O R E S

            // las clases hijas heredan los constructores de las superclases.
            // En este ejemplo tenemos la clase "Humano" que hereda de "Placentario" que hereda de "Mamifero"
            
            Mamifero ballena = new Mamifero("Willy");
            // En la clase "Mamifero" el constructor nos solicita un parametro de tipo "string" (nombre).
                        
            Placentarios caballo = new Placentarios("Tiro", false);
            // En la subclase "Placentario" estamos obligados a repetir el parametro "nombre"
            // Y añadimos un parametro boleano para definir el sexo (true para hembra, false para macho)
                                                                   
            Console.WriteLine();
            Humano manolo = new Humano("Manuel", false, 40);
            // Por ultimo la clase "Humano" repite los dos datos anteriores
            // Y añade el parametro "int" para la edad.

            // No es necesario que sea de esta manera,pero si creamos uno o varios constructores en la clase Madre (superclase)
            // esto nos obliga aque las clases hijas mantengan ese constructor.


            Console.WriteLine();



            //---------------------------------------------------------------------------------

            // C A M P O S   D E   C L A S E     (VARIABLES)

            // Solo de manera ilustrativa coloque un campo de clase público en cada clase para ver la herencia
            // Mamifero "nombre"  -  Placentario "apellido"  -  Humano "edad"  -

            ballena.nombre = "Waldo"; // Mamifero solo tiene el campo "nombre"

            caballo.nombre = "Canela";
            caballo.hembra = true; // Placentario Hereda el campo nombre y añade "apellido"
            string caballoHembra;
            if (caballo.hembra) { caballoHembra = "hembra"; }
            else {caballoHembra = "macho"; }

            manolo.nombre = "Alberto";
            manolo.hembra = false;
            manolo.edad = 41; // Humano hereda los dos campos anteriores y añade "edad"
            String humanoHembra;
            if (manolo.hembra) { humanoHembra = "hembra"; }
            else { humanoHembra = "macho"; }


            // La siguiente linea de codigo es solo para visualizar los cambios
            Console.WriteLine($"Los datos fueron modificados:\r\n" +
                $"Mamifero: {ballena.nombre}\r\n" +
                $"Placentario: {caballo.nombre}, {caballoHembra}\r\n" +
                $"Humano: {manolo.nombre}, {humanoHembra}, {manolo.edad}");

            Console.WriteLine();



            //---------------------------------------------------------------------------------

            // M E T O D O S

            // Al igual que con los campos, cada "subclase" añade un metodo a la "superclase"

            // Metodos de la clase base "Mamiferos"
            Console.WriteLine("\r\nMamifero");
            ballena.CuidarCria();
            ballena.Respirar();

            Console.WriteLine("\r\nPlacentario");
            caballo.CuidarCria();
            caballo.Respirar();
            caballo.Gestar(); // Metodo de la clase "Placentarios"

            Console.WriteLine("\r\nHumano");
            manolo.CuidarCria();
            manolo.Respirar();
            manolo.Gestar();
            manolo.Charlar(); // Metodo de la clase "Humano"


            Console.WriteLine();

        }
    }
}
