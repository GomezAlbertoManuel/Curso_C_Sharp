using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    // Por convencion las nombres de las "Inrfaces" inician con "I" en Mayuscula.
    internal interface IAvisos
    {
        // Una interfaz en C# es una especificación de un conjunto de directrices (métodos, propiedades o eventos)
        // que una clase concreta debe implementar.
        // Las interfaces se declaran usando la palabra clave "interface" y contienen miembros sin implementación.
        // Estos miembros son públicos y abstractos por naturaleza,
        // lo que significa que carecen de cuerpo o lógica definida en la interfaz misma.

        // Esto igualmente cambia a partir de la version "8" de "C#" que permite la implementacion de interfas predeterminada
        // En este proyecto no se puede implementar porque esta utilizando una version anterior a la "8"


        // En los siguientes ejemplos solamente declaramos los metodos.
        // Solo hay que declararlos ya que cada clase lo implementa de la manera que sea conveniente.
        // estos no llevan modificadores de acceso ya que todos los metodos deben ser publicos
        // las clases que hereden esta interface estan obligadas a implementar los siguientes metodos
        void MostrarAviso();

        string GetFecha();

        // El siguiente metododo solo fue creado para generar una ambiguedad entre interfaces
        String EsRepetido();                



        // R E S T R I C C I O N E S
        // .No se pueden definir campos (variables) en interfaces, solo metodos.
        // .No se pueden definir constructores
        // .No se pueden definir destructores
        // .No se pueden especificar modificadores de acceso en metodos (todos son "public" de forma implicita)
        // .No se pueden anidar clases ni otro tipo de estructuras en las interfaces


        /*         
             Las clases que implementan una interfaz deben proporcionar implementaciones concretas para todos los miembros de la interfaz. 
             De esta manera, aseguran que cumplen con el contrato especificado por la interfaz. 
             Esto permite que múltiples clases implementen la misma interfaz de manera consistente,
             facilitando la interoperabilidad y el diseño orientado a objetos.

             Las interfaces se utilizan comúnmente para definir contratos en aplicaciones C# y para lograr la abstracción. 
             Esto permite que las clases compartan un conjunto común de funcionalidades sin heredar de una clase base concreta.
           */



    }
}
