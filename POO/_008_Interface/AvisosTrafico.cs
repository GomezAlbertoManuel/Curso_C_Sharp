using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    // En este caso la clase "AvisosTrafico" esta Heredando solo de la interface "IAvisos"
    // Pero una clase puede heredar de otra clase (solo una) y de varias interfaces
    // en ese caso se declara primero la clase de la cual va a herdar y luego las intefaces separadas por comas
    // Ej.: "internal class ClaseHija : ClaseMadre, ITia, IPrimo"
    internal class AvisosTrafico : IAvisos, IAmbiguedad
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        // Tanto el metodo "GetFecha" como "MostrarAviso" son heredadas de "IAvisos" y se deben implementar obligatoriamente.
        // Ademas deben respetar el formato de los metodos declarados en la Interface
        // Si el metodo de la interface es de tipo "string", aqui ambien tiene que serlo y
        // Si el metodo resibe cierta cantidad y tipo de parametros, tambien hay que respetarlos.
        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("mensaje {0} ha sido enviado por {1} el día {2}", mensaje, remitente, fecha);
        }
        public AvisosTrafico() 
        {
            remitente = "Direccion de Transito";
            mensaje = "Sanción cometida.\r\nPague antes de 3 dias y se beneficiara con una reduccion del 50%";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }


        // --------------------------------------------------------------------------------
        // A M B I G U E D A D  E N  I N E R F A C E S

        // Tanto La interface "IAvisos" como la interface "IAmbiguedad" contienen el metodo "EsRepetido" 
        // Si implenetamos una sola vez este metodo, se genera una ambiguedad y C# asigna el metodo a ambas interfaces
        // Ejemplo:
                    // public string EsRepetido() 
                    // {
                    //    string texto = "";
                    //    return texto;
                    // }

        // Para solucionar esta ambiguedad, primero tenemos que prescindir  del modificador de acceso.
        // (Igualmente, si por error, escribieramos el modificador de acceso esto generaria un error de compilacion)
        // seguidamente del tipo de metodo (en este caso es "string") Escribimos:
        // nombre de la inteface, punto (.), nombre del metodo
        
        // NOTA: Crear los metodos sin modificador de acceso es para que este no sea accesible desde cualquier clase
        // eso nos obligara a crear objetos que pertenescan a la interface de la cual utilizaremos el metodo.

        // Este metodo se refiere al metodo de la interface "IAvisos"
        string IAvisos.EsRepetido()
        {
            string texto = "Este aviso es una repeticion de un mensage enviado a su correo electronico, por favor preste atención";
            return texto;
        }

        // Este metodo se refiere al metodo de la interface "IAmbiguedad"
        string IAmbiguedad.EsRepetido()
        {
            string texto = "Este mensaje Quizas fue enviado a su correo electronico, Si cree que es importante para usted, lealo";
            return texto;
        }

    }
}
