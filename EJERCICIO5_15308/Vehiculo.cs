using System;
namespace EJERCICIO5_15308
{
    public class Vehiculo
    {
        public SeteadorVehiculos SetV {set;get;}
        public int Power 
        {
            get;
            set;
        }
        private int SuspensionHeight 
        {
            get;
            set;
        }

        public Vehiculo(SeteadorVehiculos veh){
            this.SetV = veh;
            this.Power = this.SetV.Power;
            this.SuspensionHeight = this.SetV.SuspensionHeight;
        }
        
        public override string ToString(){
            return "Auto tipo: "+ this.SetV.GetType().Name + ", Power= " + this.Power +", SuspensionHeight= "+ this.SuspensionHeight;
        }
    }

}