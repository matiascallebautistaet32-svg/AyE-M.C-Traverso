using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    public class Tree
    {
        public Nodo ra { get; set; }

        public Tree()
        {
            ra = null;
        }

        public void Inserto(Agentes nuevoAgente)
        {
            ra = Insertando(nuevoAgente, ra);
        }

        public Nodo Insertando(Agentes nuevoAgente, Nodo nodoAct)
        {
            if (nodoAct == null)
            {
                return new Nodo(nuevoAgente);
            }

            if (nuevoAgente.id < nodoAct.agente.id)
            {
                nodoAct.nodoI = Insertando(nuevoAgente, nodoAct.nodoI);
            }
            else if (nuevoAgente.id > nodoAct.agente.id)
            {
                nodoAct.nodoD = Insertando(nuevoAgente, nodoAct.nodoD);
            }

            return nodoAct;
        }

        public string Buscar(int idBusc)
        {
            if (ra == null)
            {
                return "Arbol vacio";
            }

            return Buscando(ra, idBusc);
        }

        public string Buscando(Nodo nodoA, int idBusc)
        {
            if (nodoA == null)
            {
                return $"No hay agentes con el ID {idBusc}.";
            }

            if (idBusc == nodoA.agente.id)
            {
                return $"Agente encontrado: Nombre:{nodoA.agente.nombre_agente} Tipo:{nodoA.agente.tipo_agente} Pais:{nodoA.agente.nacionalidad} Fecha de Lanzamiento:{nodoA.agente.fecha_lanzamiento}";
            }

            if (idBusc < nodoA.agente.id)
            {
                return Buscando(nodoA.nodoI, idBusc);
            }
            else
            {
                return Buscando(nodoA.nodoD, idBusc);
            }
        }
    }

}
