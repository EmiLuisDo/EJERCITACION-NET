using System;
namespace EJERCICIO2_14705
{
    class Pasajero : Persona{
        private long nroPasajero;
        public long NroPasajero{
            get{return nroPasajero;}
            set{nroPasajero = value;}
        }
        private String nacionalidad ;
        public String Nacionalidad{
            get{return nacionalidad;}
            set{nacionalidad = value;}
        }

        public Pasajero (String nombre, String apellido, DateTime fechaNacimiento, long nroPasajero, String nacionalidad)
            :base(nombre, apellido, fechaNacimiento)
            {
                this.nroPasajero = nroPasajero;
                this.nacionalidad = nacionalidad;
        }

        public override string ToString()
        {
            return "_Pasajero{NumeroPasajero= "+this.nroPasajero+", nacionalidad= "+this.nacionalidad+", "+base.ToString()+"}";
        }
    }
}