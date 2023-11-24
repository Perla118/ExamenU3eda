using ExamenU3eda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3eda
{
    public class Lista
    {
        private Nodo inicio;

        //Lista esta vacia
        public bool ListaVacia()
        {
            return inicio == null;
        }



        //Insertar al final
        public void InsertarAlFinal(Persona persona)
        {
            Nodo nuevoNodo = new Nodo { DatosPersona = persona, Siguiente = null };

            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                ObtenerUltimoNodo().Siguiente = nuevoNodo;
            }
        }
        // lista
        public bool Buscar(Persona persona)
        {
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.DatosPersona.Equals(persona))
                {
                    return true;
                }
                actual = actual.Siguiente;
            }

            return false;
        }
        
        public int Posicion(Persona persona)
        {
            int posicion = 0;
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.DatosPersona.Equals(persona))
                {
                    return posicion;
                }
                actual = actual.Siguiente;
                posicion++;
            }

            return -1;
        }


        //Imprimir lista 
        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = inicio;

            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.DatosPersona.Nombre}, Edad: {actual.DatosPersona.Edad}");
                actual = actual.Siguiente;
            }
        }

        private Nodo ObtenerUltimoNodo()
        {
            Nodo actual = inicio;

            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            return actual;
        }

    }
}


        
  
  
