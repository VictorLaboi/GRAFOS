using System;

namespace ListasSimplementeLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista list = new Lista();

            list.AgregarNodo("A");
            list.AgregarNodo("B");
            list.AgregarNodo("C");
            list.AgregarNodo("D");
            list.AgregarNodo("E");

            // Agregar aristas a la lista
            list.AgregarArit(0, 1);
            list.AgregarArit(0, 4);
            list.AgregarArit(1, 2);
            list.AgregarArit(1, 3);
            list.AgregarArit(1, 4);
            list.AgregarArit(2, 3);
            list.AgregarArit(3, 4);

            // Mostrar la lista
            list.ImprimirGrafo();
        }
    }
}

