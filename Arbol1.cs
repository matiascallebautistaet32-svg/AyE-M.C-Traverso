using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa8;

namespace Programa8
{
    internal class Arbol
    {
        public Pokemones Raiz { get; set; }

        public Arbol()
        {
            Raiz = null;
        }
        public string Buscar(int IDBuscar)
        {

            if (Raiz == null)
            {
                return "El árbol está vacío.";
            }
            return BuscarRecursivo(Raiz, IDBuscar);
        }


        private string BuscarRecursivo(Pokemones nodoActual, int IDBuscar)
        {

            if (nodoActual == null)
            {
                return $"No se encontró ningún Pokémon con el ID {IDBuscar}.";
            }


            if (IDBuscar == nodoActual.id)
            {
                return $"Pokémon encontrado: {nodoActual.nombre}";
            }


            if (IDBuscar < nodoActual.id)
            {
                return BuscarRecursivo(nodoActual.izquierdo, IDBuscar);
            }

            else
            {
                return BuscarRecursivo(nodoActual.derecho, IDBuscar);
            }
        }




        public void Insertar(Pokemones Nuevo)
        {

            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {

                InsertarRecursivo(Raiz, Nuevo);
            }
        }

        private void InsertarRecursivo(Pokemones nodoActual, Pokemones Nuevo)
        {

            if (Nuevo.id < nodoActual.id)
            {
                if (nodoActual.izquierdo == null)
                {
                    nodoActual.izquierdo = Nuevo;
                }
                else
                {
                    InsertarRecursivo(nodoActual.izquierdo, Nuevo);
                }
            }

            else if (Nuevo.id > nodoActual.id)
            {
                if (nodoActual.derecho == null)
                {
                    nodoActual.derecho = Nuevo;
                }
                else
                {
                    InsertarRecursivo(nodoActual.derecho, Nuevo);
                }
            }
        }
    }
}