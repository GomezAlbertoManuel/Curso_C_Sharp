using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Herencia
{
    internal class Placentarios : Mamifero
    {        
        public bool hembra;
        
        public Placentarios(string nombre, bool hembra) : base(nombre)
        {
            if (hembra) { Console.WriteLine("es hembra.\r\n"); }
            else { Console.WriteLine("es macho.\r\n"); }
            this.hembra = hembra;          
        }


        public void Gestar() 
        {
            if (this.hembra){ Console.WriteLine("Estoy gestando vida en mi interior"); }
            else { Console.WriteLine("Solo las hembras son capaces de gestar"); }
        }           
      
    }
}

          /*
           * otras subdivisiones para Placentarios:
            a. Carnívoros: Incluye animales como leones, tigres, lobos y osos.
            b. Herbívoros: Animales que se alimentan principalmente de plantas, como elefantes, jirafas y vacas.
            c. Omnívoros: Mamíferos que comen tanto carne como plantas, como los seres humanos, osos pardos y cerdos.
            d. Roedores: Este grupo incluye a los animales que tienen dientes incisivos continuamente en crecimiento, como ratones, ardillas y castores.
            e. Cetáceos: Mamíferos marinos como ballenas y delfines.
            f. Murciélagos: Son los únicos mamíferos voladores conocidos.
            g. Primates: Incluye a los seres humanos, monos y simios.
            h. Artiodáctilos: Mamíferos con pezuñas impares, como caballos, vacas y cerdos.
            i. Perisodáctilos: Mamíferos con pezuñas pares, como caballos, rinocerontes y tapires.
          */