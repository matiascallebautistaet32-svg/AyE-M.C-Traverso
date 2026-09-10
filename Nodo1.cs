using System;

namespace ConsoleApp1
{
    internal class Nodo
    {
        public int valor { get; set; }
        public Nodo izquierdo { get; set; }
        public Nodo derecho { get; set; }

        public Nodo(int valor)
        {
            this.valor = valor;
            izquierdo = null;
            derecho = null;
        }
    }
}


