using System;
namespace EJERCICIO5_15308
{
    public class Vehiculo
    {
        public TipoConduccion TC 
        {
            set;
            get;
        }
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

        public Vehiculo(){
            
        }

        public Vehiculo(TipoConduccion veh){
            this.TC = veh;
            this.Power = this.TC.Power;
            this.SuspensionHeight = this.TC.SuspensionHeight;
        }

        public void refrescarParametros(){
            this.Power = TC.Power;
            this.SuspensionHeight = TC.SuspensionHeight;
        }
        
        public override string ToString(){
            return "Auto tipo: "+ this.TC.GetType().Name + ", Power= " + this.Power +", SuspensionHeight= "+ this.SuspensionHeight;
        }
    }

}