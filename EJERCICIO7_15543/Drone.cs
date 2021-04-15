using System;
namespace EJERCICIO7_15543
{
    public class Drone : IControlRemoto, IControlRemotoVolador
    {
        public int Id{get;set;}

        private int estadoMotor;
        private int estadoCamara;
        public int EstadoMotor
        {
            get{return estadoMotor;}
            set{estadoMotor = value;}
        }
        public int EstadoCamara
        {
            get{return estadoCamara;}
            set{estadoCamara = value;}
        }
        public int arrancarMotor()
        {
            this.estadoMotor = 1;
            return this.estadoMotor;            
        }
        
        public int prenderCamara()
        {
            this.estadoCamara=1;
            return this.estadoCamara;
        }
        public int apagarCamara()
        {
            this.estadoCamara = 0;
            return this.estadoCamara;
        }
        public Drone(int id)
        {
            this.Id = id;
            this.EstadoMotor = 0;
            this.EstadoCamara = 0;
        }
        public override string ToString()
        {
            return "_Drone: Id="+this.Id+", EstadoMotor="+this.EstadoMotor+", EstadoCamara="+this.EstadoCamara;
        }
    }
}