using proyecto1progra3Brayan.clases.ArbolBinario;
using proyecto1progra3Brayan.clases.Bd;
using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto1progra3Brayan.clases.juego
{
    class AdivinaAnimal
    {
        private static nodo raiz;


        public AdivinaAnimal()
        {
            raiz = new nodo("Elefante");
        }

        public void jugar(int validarjuego)
        {
           

            if (validarjuego == 0 ) 
            {
                
                cargarAllArbol(); 
            }
         


            nodo _nodo = raiz;

            while (_nodo != null)//iteracion del arbol...codigo de la clase
            {
                if (_nodo.izquierda != null)
                {
                    Console.WriteLine(_nodo.valorNodo());
                    _nodo = (respuesta()) ? _nodo.izquierda : _nodo.derecha;
                }
                else
                {
                    Console.WriteLine($"Ya se, es un {_nodo.valorNodo()}");
                    if (respuesta())
                    {

                       
                        Console.WriteLine("Gane!!! :)");
                    }
                    else
                    {
                       
                        animalNuevo(_nodo);
                    }
                    _nodo = null;
                    return;
                }
            }

        }


        public bool respuesta()
        {
            while (true)
            {
                string resp = Console.ReadLine().ToLower().Trim();
                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser si o no");
            }
        }

        private void animalNuevo(nodo nodo)
        {
            clsconection conexion = new clsconection();


            int validar = 0;
            string animalNodo = (string)nodo.valorNodo();
            Console.WriteLine("Cual Es Tu Animal Entonces?");
            string nuevoA = Console.ReadLine();
            Console.WriteLine($"Que pregunta con respuest si/no puedo hacer que es un {nuevoA}");
            string pregunta = Console.ReadLine();
            nodo nodo1 = new nodo(animalNodo);
            nodo nodo2 = new nodo(nuevoA);
            Console.WriteLine($"Para un(a) {nuevoA} la respuesta es si/no?");
            nodo.nuevoValor(pregunta + "?");
            conexion.queryInsertar(nuevoA, pregunta, validar);
            if (respuesta())
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;
            }
            else
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;
            }

        }

        //metodo para la carga del arbol a partir de los datos de la db
        public void cargarAllArbol()
        {
            clslistas n = new clslistas();
            n.cargarlistas();

            for (int i = 0; i < n.nombre.Count; i++)
            {
               

                nodo nuevonodo = new nodo(n.descripcion[i]);
                nuevonodo.derecha = raiz;
                nuevonodo.izquierda = new nodo(n.nombre[i]);
                raiz = nuevonodo;


            }

        }

        //metodo para la grafica que los datos que se encuentran en la db
        public void graficas()
        {
            string pincel = "";
            clslistas n = new clslistas();
            n.cargarlistas();
            for (int i = 0; i < n.nombre.Count; i++)
            {
                Console.WriteLine(pincel + n.nombre[i] + "-" + n.descripcion[i]);
                pincel += " - -  -  - - ";
            }



        }
    }
}
