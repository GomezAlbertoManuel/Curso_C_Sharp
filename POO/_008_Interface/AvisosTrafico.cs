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
    internal class AvisosTrafico : IAvisos
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

    }
}
