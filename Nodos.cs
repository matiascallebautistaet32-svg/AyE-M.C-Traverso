using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    public class Nodo
    {
        public Agentes agente { get; set; }
        public Nodo nodoI { get; set; }
        public Nodo nodoD { get; set; }

        public Nodo(Agentes agente)
        {
            this.agente = agente;
            nodoD = null;
            nodoI = null;
        }
    }
}

