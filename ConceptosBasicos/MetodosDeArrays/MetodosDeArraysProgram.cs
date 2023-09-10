using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeArrays
{
    internal class MetodosDeArraysProgram
    {
        static void Main(string[] args)
        {
            int[] pares = new int[4];

            pares[0] = 2;
            pares[1] = 4;
            pares[2] = 6;
            pares[3] = 8;

            MetodoConArray(pares);
            
        }

        
        static int[] MetodoConArray(int[] array) 
        {
            foreach (int i  in array) 
            {                
                Console.WriteLine(i + 10);
            }        
            return array;
        }
        
        /*
        static void MetodoConArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }            
        }
        */
    }
}
