using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{   
    internal class InterfacesProgram
    {
        static void Main(string[] args)
        {
            AvisosTrafico aviso1 = new AvisosTrafico();
            aviso1.MostrarAviso();

            AvisosTrafico aviso2 = new AvisosTrafico("Jefatura Provincial", "Exceso de velocidad", "04/10/2023");

            Console.WriteLine(aviso2.GetFecha());

            aviso2.MostrarAviso();

            Console.WriteLine("\r\nA M B I G U E D A D\r\n \r\n");
            // ----------------------------------------------------------------------
            // A M B I G U E D A D
            // Utilizar metodos que se repiten en interfaces


            // Crear los metodos sin modificador de acceso nos obligara a crear objetos
            // que pertenescan a la interface de la cual utilizaremos el metodo.
            // Para poder indicarle a C# que metodo queremos utilizar cuando este esta repetido en varias interfaces
            // lo que debemos hacer es utilizar el principio de sustiucion creando el objeto utilizando el nombre de la interface.
            // Podemos crear un objeto nuevo o otilizar uno existente

            // Objeto nuevo utilizando interface "IAviso"
            IAvisos ambiguedad1 = new AvisosTrafico();
            Console.WriteLine("\r\nMetodo \"EsRepetido\" desde interface \"IAvisos\"");
            Console.WriteLine(ambiguedad1.EsRepetido());

            // Objeto nuevo utilizando interface "IAmbiguedad"
            IAmbiguedad ambiguedad2 = new AvisosTrafico();
            Console.WriteLine("\r\nMetodo \"EsRepetido\" desde interface \"IAmbiguedad\"");
            Console.WriteLine(ambiguedad2.EsRepetido());

            // Objeto creado anteriormente utilizando interface "IAviso"
            IAvisos ambiguedad3 = aviso1;
            Console.WriteLine("\r\nMetodo \"EsRepetido\" desde interface \"IAvisos\" Usando principio de sustitucion.");
            Console.WriteLine(ambiguedad3.EsRepetido());

            // Objeto creado anteriormente utilizando interface "IAmbiguedad"
            IAmbiguedad ambiguedad4 = aviso2;
            Console.WriteLine("\r\nMetodo \"EsRepetido\" desde interface \"IAmbiguedad\" Usando principio de sustitucion.");
            Console.WriteLine(ambiguedad4.EsRepetido());



            Console.WriteLine("\r\n");




        }
    }
}
