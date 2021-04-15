using System;
namespace EJERCICIO7_15543
{
    public class Auto: IControlRemoto, IControlRemotoTerrestre
    {

        public int Id{get;set;}
        private int estadoMotor;
        private int estadoRadio;
        public int EstadoMotor
        {
            get{return estadoMotor;}
            set{estadoMotor = value;}
        }
        public int EstadoRadio
        {
            get{return estadoRadio;}
            set{estadoRadio = value;}
        }
        public int arrancarMotor()
        {
            this.estadoMotor = 1;
            return this.estadoMotor;
        }
        public int prenderRadio()
        {
            this.estadoRadio = 1;
            return this.estadoRadio;
        }
        public int apagarRadio()
        {
            this.estadoRadio = 0;
            return this.estadoRadio;
        }
        public Auto(int id){
            this.Id = id;
            this.EstadoMotor = 0;
            this.EstadoRadio = 0;
        }

        public override string ToString()
        {
            return "_Auto: Id="+this.Id+", EstadoMotor="+this.EstadoMotor+", EstadoRadio="+this.EstadoRadio;
        }
    }    
}