using System;

namespace Ejercicio2_14705
{
    class Persona{

        private String nombre;
        public String Nombre
        {
            get{return nombre;}
            set{nombre = value;}
        }

        private String apellido;
        public String Apellido{
            get{return apellido;}
            set{apellido=value;}
        }

        private DateTime fechaNacimiento ;
        public DateTime FechaNacimiento{
            get{return fechaNacimiento;}
            set{fechaNacimiento = value;}
        }
        private int edad;
        public int Edad{
            get{return calcularEdad(fechaNacimiento);}        
            }

        public Persona (String nombre, String apellido, DateTime fechaNacimiento){
            this.nombre= nombre;
            this.apellido=apellido;
            this.fechaNacimiento=fechaNacimiento;
        }
        private int calcularEdad(DateTime fechaNacimiento){
            DateTime hoy= DateTime.Today;
            int edad = fechaNacimiento.Year - fechaNacimiento.Year;
            return edad;
        }
    }

}
