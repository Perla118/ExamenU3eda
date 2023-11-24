using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3eda
{
    public class Nodo
    {
        private Persona _DatosPersona;
        private Nodo _Siguiente;

        public Nodo()
        {
            _Siguiente = null;
        }
        public Nodo(Persona persona, Nodo Siguiente = null)
        {
            DatosPersona = persona;
            _Siguiente = null;

        }

        public Persona DatosPersona
        {
            get { return _DatosPersona; }
            set { _DatosPersona = value; }
        }

        public Nodo Siguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }

    }
}

