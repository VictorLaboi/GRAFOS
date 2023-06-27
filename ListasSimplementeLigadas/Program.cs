using System;
using System.Collections.Generic;
namespace ListasSimplementeLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Lista vertA = new Lista("A");
            Lista vertB = new Lista("B");
            Lista vertC = new Lista("C");
            Lista vertD = new Lista("D");

            vertA.AgregarArit(vertB);
            vertA.AgregarArit(vertC);
            vertB.AgregarArit(vertD);

            Grafo.Add(vertA);
            Grafo.Add(vertB);
            Grafo.Add(vertC);
            Grafo.Add(vertD);
            Console.ReadKey();
        }
    }
}

