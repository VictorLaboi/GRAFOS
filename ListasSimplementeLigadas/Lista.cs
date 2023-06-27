using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplementeLigadas
{
    public class Lista
    {
        public Nodo nodoInicio;
        List<Lista> Grafo = new List<Lista>();
        public Lista(string valor)
        {
            nodoInicio = new Nodo(valor);
        }
        public void AgregarNodo(string valor) {
            Nodo nodoActual = nodoInicio;
            while (nodoActual.Siguiente != null) {
                nodoActual = nodoActual.Siguiente;
            }
            nodoActual.Siguiente = new Nodo(valor);
        }
        public void AgregarArit(Lista vertices) {
            AgregarNodo(vertices.nodoInicio.Valor);
        }
    }
}
