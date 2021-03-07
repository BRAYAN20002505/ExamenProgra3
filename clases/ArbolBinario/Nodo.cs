using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto1progra3Brayan.clases.ArbolBinario
{
    class nodo
    {
        public object dato;
        public nodo izquierda;
        public nodo derecha;

        public nodo(object valor)
        {
            dato = valor;
            izquierda = null;
            derecha = null;
        }

        public nodo(nodo ramaIzquierda, object valor, nodo ramaDerecha)
        {
            dato = valor;
            izquierda = ramaIzquierda;
            derecha = ramaDerecha;
        }

        public object valorNodo()
        {
            return dato;
        }

        public nodo subarbolDerecho()
        {
            return derecha;
        }

        public nodo subarbolIzquierdo()
        {
            return izquierda;
        }

        public void nuevoValor(object nv)
        {
            dato = nv;
        }

        public void ramaIzquierda(nodo n)
        {
            izquierda = n;
        }

        public void ramaDerecha(nodo n)
        {
            derecha = n;
        }


        public void visitar()
        {
            Console.WriteLine(dato + "<-> ");
        }
    }
}
