using proyecto1progra3Brayan.clases.ArbolBinario;
using proyecto1progra3Brayan.clases.juego;
using System;

namespace proyecto1progra3Brayan
{
    class Program
    {
        public static void preorden(nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquierdo());
                preorden(r.subarbolDerecho());
            }
        }

        public static void inorden(nodo r)
        {
            if (r != null)
            {
                inorden(r.subarbolIzquierdo());
                r.visitar();
                inorden(r.subarbolDerecho());
            }
        }

        public static void postorden(nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }

        static void Main(string[] args)
        {
             juegoAnimales();

          
        }

        public static void juegoAnimales()
        {
            Console.WriteLine("JUGUEMOS A ADIVINAR ANIMALES ;)");
            Boolean otrojuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();


            int validarjuego = 0;
            do
            {
                
                juego.jugar(validarjuego);
                validarjuego = 1;
                Console.WriteLine("jugamos otra vez?");
                otrojuego = juego.respuesta();
            } while (otrojuego);
           
            
            Console.Clear();
            Console.WriteLine("Deseas ver la grafica del arbol");
            if (juego.respuesta())
                juego.graficas();
            

                    
        }


    }
}
