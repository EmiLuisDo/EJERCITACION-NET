using System;

namespace Ejercicio2_14705
{
    class Pasajero : Persona{

        private long nroPasajero;
        public long NroPasajero{
            get{return nroPasajero;}
            set{nroPasajero=value;}
        }

        private String nacionalidad;
        public String Nacionalidad{
            get{return nacionalidad;}
            set{nacionalidad=value;}
        }

        public Pasajero(String nombre, String apellido, DateTime fechaNacimiento, long nroPasajero, String nacionalidad )
            : base(nombre, apellido, fechaNacimiento)
            {
                this.nroPasajero = nroPasajero;
                this.nacionalidad = nacionalidad;
        }
    }
}