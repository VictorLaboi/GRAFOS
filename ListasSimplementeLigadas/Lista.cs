using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplementeLigadas
{
    public class Lista
    {
        private List<Nodo> nodos;

        public Lista()
        {
            nodos = new List<Nodo>();
        }
        public void AgregarNodo(string valor) { 
            Nodo nuevoNod = new Nodo(valor);
            nodos.Add(nuevoNod);
        }
        public void AgregarArit(int firstIndice, int secondIndice) {
            if (firstIndice < 0 || firstIndice >= nodos.Count || secondIndice < 0 || secondIndice >= nodos.Count) {
                Console.WriteLine("Errror, los indices exceden el rango de los elementos en la lista");
            }
            Nodo nodoInicial = nodos[firstIndice];
            Nodo nodoFinal = nodos[secondIndice];

            nodoInicial.Aristas.Add(nodoFinal);
        }
        public void ImprimirGrafo() {
            for(int i= 0;i<nodos.Count;i++)
            {
                Console.Write(i + "---->");
                foreach (var arist in nodos[i].Aristas)
                {
                    Console.Write(arist.Valor + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
