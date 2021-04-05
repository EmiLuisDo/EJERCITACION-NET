
using System;
using System.Collections.Generic;
namespace EJERCICIO3_14843
{
    public class Persona : IComparable<Persona>
    {
        public static readonly int masculino = 1;
        public static readonly int femenino = 0;
        private String nombre;
        private String apellido;
        public String Apellido{
            get{return apellido;}
        }
        public String NombreCompleto{
            get{return $"{nombre} {apellido}";}
        }
        private int sexo;

        private DateTime fechaNacimiento;
        public int Edad{
            get{return calcularEdad(fechaNacimiento);}
        }

        private int calcularEdad (DateTime fechaNacimiento){
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            return edad;
        }

        public bool sosMujer(){
            bool rta = false;
            if (this.sexo == Persona.femenino){
                rta = true;
            }
            return rta;
        }
        public bool sosHombre(){
            bool rta = false;
            if (this.sexo == Persona.masculino){
                rta = true;
            }
            return rta;
        }
        public bool sosMayor(){
            bool rta = false;
            if (this.Edad >=18 ){
                rta = true;
            }
            return rta;
        }
        public bool apellidoEmpiezaCon(char letra){
            bool rta = false;
            if(this.apellido[0] == letra){
                rta = true;
            }
            return rta;
        }


        public override string ToString()
        {
            return "_Persona:{nombreCompleto = "+this.NombreCompleto+", sexo = "+Persona.obtenerSexo(this.sexo)+", edad = "+this.Edad+"}";
        }

        public Persona (String nombre, String apellido, int sexo, DateTime fechaNacimiento){
            this.nombre = nombre;
            this.apellido=apellido;
            this.sexo = sexo;
            this.fechaNacimiento=fechaNacimiento;
        }

        public static String obtenerSexo(int sexoI){
            String sexoS = "Desconocido";
            if (sexoI == Persona.femenino){
                sexoS="Femenino";
            }
            if(sexoI == Persona.masculino){
                sexoS = "Masculino";
            }
            return sexoS;
        }

            public int CompareTo(Persona other)
            {
                // If other is not a valid object reference, this instance is greater.
                if (other == null) return 1;

                // The temperature comparison depends on the comparison of
                // the underlying Double values.
                return NombreCompleto.CompareTo(other.NombreCompleto);
            }

    }
}