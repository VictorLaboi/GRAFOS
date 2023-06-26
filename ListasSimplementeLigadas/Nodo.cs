using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplementeLigadas
{
    public class Nodo
    {
        public string Valor { get; set; }
        public List<Nodo> Aristas { get; set; }

        public Nodo(string valor = "", Nodo enlace = null)
        {
            Valor = valor;
            Aristas = new List<Nodo>();
        }
    }
}

