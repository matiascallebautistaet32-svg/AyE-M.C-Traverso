using System;

namespace ConsoleApp1
{
    internal class Arbol
    {
        public Nodo raiz { get; set; }

        public Arbol()
        {
            raiz = null;
        }

        public void insertar(int valor)
        {
            raiz = insertarRecursivo(raiz, valor);
        }

        private Nodo insertarRecursivo(Nodo nodoActual, int valor)
        {
            if (nodoActual == null)
            {
                return new Nodo(valor);
            }
            if (valor < nodoActual.valor)
            {
                nodoActual.izquierdo = insertarRecursivo(nodoActual.izquierdo, valor);
            }
            else if (valor > nodoActual.valor)
            {
                nodoActual.derecho = insertarRecursivo(nodoActual.derecho, valor);
            }

            return nodoActual;
        }

        public bool buscar(int valor)
        {
            return buscarRecursivo(raiz, valor);
        }

        private bool buscarRecursivo(Nodo nodoactual, int valor)
        {
            if (nodoactual == null)
            {
                return false;
            }
            if (nodoactual.valor == valor)
            {
                return true;
            }
            if (valor < nodoactual.valor)
            {
                return buscarRecursivo(nodoactual.izquierdo, valor);
            }
            else
            {
                return buscarRecursivo(nodoactual.derecho, valor);
            }
        }


        public int ObtenerMinimo()
        {
            if (raiz == null)
                throw new InvalidOperationException("El árbol está vacío.");

            Nodo actual = raiz;
            while (actual.izquierdo != null)
            {
                actual = actual.izquierdo;
            }
            return actual.valor;
        }

        public int ObtenerMaximo()
        {
            if (raiz == null)
                throw new InvalidOperationException("El árbol está vacío.");

            Nodo actual = raiz;
            while (actual.derecho != null)
            {
                actual = actual.derecho;
            }
            return actual.valor;
        }


        public int ObtenerCantidadNodos()
        {
            return ContarNodosRecursivo(raiz);
        }

        private int ContarNodosRecursivo(Nodo nodo)
        {
            if (nodo == null) return 0;
            return 1 + ContarNodosRecursivo(nodo.izquierdo) + ContarNodosRecursivo(nodo.derecho);
        }

        public int ObtenerAltura()
        {
            return ObtenerAlturaRecursivo(raiz);
        }

        private int ObtenerAlturaRecursivo(Nodo nodo)
        {
            if (nodo == null) return 0;

            int altIzq = ObtenerAlturaRecursivo(nodo.izquierdo);
            int altDer = ObtenerAlturaRecursivo(nodo.derecho);

            return 1 + Math.Max(altIzq, altDer);
        }

        // 4. ContarHojas
        public int ContarHojas()
        {
            return ContarHojasRecursivo(raiz);
        }

        private int ContarHojasRecursivo(Nodo nodo)
        {
            if (nodo == null) return 0;
            if (nodo.izquierdo == null && nodo.derecho == null) return 1;

            return ContarHojasRecursivo(nodo.izquierdo) + ContarHojasRecursivo(nodo.derecho);
        }

        // 5. Eliminar
        public void Eliminar(int valor)
        {
            raiz = EliminarRecursivo(raiz, valor);
        }

        private Nodo EliminarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null) return null;

            if (valor < nodo.valor)
            {
                nodo.izquierdo = EliminarRecursivo(nodo.izquierdo, valor);
            }
            else if (valor > nodo.valor)
            {
                nodo.derecho = EliminarRecursivo(nodo.derecho, valor);
            }
            else
            {

                if (nodo.izquierdo == null) return nodo.derecho;
                if (nodo.derecho == null) return nodo.izquierdo;


                nodo.valor = EncontrarMinimoValor(nodo.derecho);

                nodo.derecho = EliminarRecursivo(nodo.derecho, nodo.valor);
            }

            return nodo;
        }

        private int EncontrarMinimoValor(Nodo nodo)
        {
            int min = nodo.valor;
            while (nodo.izquierdo != null)
            {
                min = nodo.izquierdo.valor;
                nodo = nodo.izquierdo;
            }
            return min;
        }

        // 6. EsValido
        public bool EsValido()
        {
            return EsValidoRecursivo(raiz, null, null);
        }

        private bool EsValidoRecursivo(Nodo nodo, int? min, int? max)
        {
            if (nodo == null) return true;


            if ((min != null && nodo.valor <= min) || (max != null && nodo.valor >= max))
            {
                return false;
            }


            return EsValidoRecursivo(nodo.izquierdo, min, nodo.valor) &&
                   EsValidoRecursivo(nodo.derecho, nodo.valor, max);
        }
    }
}
