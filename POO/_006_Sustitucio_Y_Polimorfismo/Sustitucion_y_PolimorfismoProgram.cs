using _005_Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Sustitucio_Y_Polimorfismo
{
    internal class Sustitucion_y_PolimorfismoProgram
    {        
        static void Main(string[] args)
        {
            // El principio de sustitución en C# permite que una subclase pueda ser usada
            // en lugar de su superclase sin impactar la funcionalidad del programa,
            // facilitando la creación de jerarquías de clases y el uso de polimorfismo
            // para escribir código más flexible y reutilizable.

            // Teniendo en cuenta el Principio de sustitucion, podemos crear un "Humano" que sea "Mamifero"
            // Pero no al revez, ya que un humano siempre va a ser un "Mamifero",
            // Pero Un "Mamifero" no siempre va a ser un "Humanmo" 
            Mamifero jose = new Humano("José", false, 22);

            // El inconveniente es que al crear un "humano de esta manera este solo temdra las propiedades de la clase "base"
            // ya que se comporta como un "Mamifero" y no como un humano.
            // Por ejemplo el metodo Pensar de jose es, el pensamiento basico de un mamifero
            // y solo se puede acceder al campo nombre de "Mamifero" y no a los campos de "Humano"
            jose.Pensar();
            Console.WriteLine(jose.nombre);

            // Una manera de solucionar esto seria crear metodos "virtual" en la clase madre (superclase)
            // que podemos reemplazar en las clases hijas (subclases) con metodos "override".
            // El siguiente metodo "Desplazar" es virtual en la clase "Mamifero" y nos devuelve el string "Puedo desplazarme",
            // pero la clase "Humano lo sobreescribe y nos devuelve el string "Puedo caminar" (esto es devido al polimorfismo)
            jose.Desplazar();

            // La clase "placentarios" no tiene su propio metodo "Desplazar"
            // Por eso utiliza el mismo metodo de la clase "Mamifero"
            Mamifero delfin = new Placentarios("flyper", true);
            delfin.Desplazar();


            //------------------------------------------------------------
            // P O L I M O R F I S M O

            // El polimorfismo se refiere a la capacidad de los objetos de clases diferentes
            // de responder de manera diferente a la misma llamada de método.
            // Hay dos tipos principales de polimorfismo en programación orientada a objetos: 

            // Polimorfismo Estático (o de compilación)
            // Esto ocurre cuando se utiliza la sobrecarga de métodos.
            // El método que se llama se resuelve en tiempo de compilación en función de los argumentos utilizados en la llamada.
            jose.Respirar();
            jose.Respirar(true);
            jose.Respirar(false);
            jose.Respirar(true,30);

            Console.WriteLine();

            // Polimorfismo Dinámico (o de tiempo de ejecución)
            // Esto se relaciona con la herencia y la capacidad de una clase derivada (subclase) de
            // sobrescribir un método de su clase base (superclase).
            // Cuando se llama a un método en un objeto, el método que se ejecuta se determina
            // en tiempo de ejecución según el tipo real del objeto.
            // Esto permite que diferentes clases proporcionen implementaciones diferentes para el mismo método.
            // (esto ya fue demostrado con el metodo "Desplazar" de la clase "Mamifero"            
            delfin.Desplazar();
            jose.Desplazar();
            // Ambas instancias estan declaradas como mamiferos y utilizan el mismo metodo
            // pero jose tiene sobrescrito el metodo desplazar, por eso se comporta distinto.
            
            // En la siguiente linea convierto al "delfin" en "jose" es una de las maneras de demostrar el polimorfismo
            // Realizando esta accion se logra que varios objetos que heredan de la misma clase intercambien sus atributos y metodos
            delfin = jose;

            Console.WriteLine($"Metamorfosis de delfin a humano \r\nAhora el delfin se llama {delfin.nombre}");
            delfin.Desplazar();



            // En resumen, la sobrecarga de métodos es una forma de polimorfismo estático,
            // mientras que el polimorfismo dinámico se refiere a la capacidad de los objetos de clases relacionadas
            // de comportarse de manera diferente en tiempo de ejecución.
            // Ambos conceptos son importantes en la programación orientada a objetos
            // y permiten escribir código más flexible y reutilizable. 




            //-------------------------------------------------------------------------------                        
            // P A L A B R A  C L A V E  N E W

            // La palabra reservada "new" en C# no está directamente relacionada con el polimorfismo.
            // "New" se utiliza en C# en diferentes contextos y con diferentes significados,
            // pero principalmente se utiliza para crear una nueva instancia de un objeto
            // o para ocultar un miembro heredado en una clase derivada.

            // Cuando se utiliza "new" para ocultar un miembro heredado en una clase derivada,
            // se está realizando lo que se conoce como "ocultación de miembros" o "ocultación de métodos".
            // Esto puede tener un impacto en la forma en que se comporta una clase derivada en relación con el polimorfismo.
            // Cuando un miembro se oculta en una clase derivada,
            // no se utiliza la versión del miembro de la clase base en las llamadas a métodos en la clase derivada.
            // En cambio, se utiliza la versión oculta en la clase derivada.
            // Esto puede llevar a resultados inesperados si no se tiene en cuenta al usar polimorfismo.

            // Sin embargo, el polimorfismo en C# se logra principalmente a través de la herencia y las interfaces,
            // utilizando palabras reservadas como "override" (para reemplazar un método virtual de la clase base en una clase derivada)
            // y "virtual" (para declarar un método que puede ser anulado en clases derivadas).
            // "New" se usa para ocultar miembros heredados, pero no es la principal herramienta para lograr el polimorfismo.

            // En resumen, mientras que "new" puede afectar la forma en que los miembros se comportan en una jerarquía de clases,
            // el polimorfismo en C# se basa principalmente en conceptos como "override" y "virtual", junto con la herencia y las interfaces.


            Mamifero ballena = new Acuatico("Willy", true);
            Acuatico foca = new Acuatico("Nelson", false);

            Console.WriteLine();

            // En este ejemplo "ballena" fue declarada como "Mamifero" y "foca" como "Acuatico".
            // Aunque ambos son de clase "Acuatico" y ambas estan utilizando el metodo "Desplazar"
            // El comportamiento es diferente porque el metodo esta declarado como "new"
            // esto quiere decir que oculta el metodo de la clase madre, pero no lo sobreescribe.
            ballena.Desplazar();
            foca.Desplazar();


        }
    }
}