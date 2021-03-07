using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto1progra3Brayan.clases.ArbolBinario
{
    class arbolBinario
    {
        protected nodo raiz;

        public arbolBinario()
        {
            raiz = null;
        }

        public arbolBinario(nodo valorRaiz)
        {
            this.raiz = valorRaiz;
        }

        public nodo raizArbol()
        {
            return raiz;
        }

        bool esVacio()
        {
            return raiz == null;
        }

        public static nodo nuevoArbol(nodo ramaIzqda, object dato, nodo ramaDrcha)
        {
            return new nodo(ramaIzqda, dato, ramaDrcha);
        }





    }
}
