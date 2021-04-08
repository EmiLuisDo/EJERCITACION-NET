using System;
namespace EJERCICIO4_15255
{
    public class Vehiculo
    {
        private Tanque tanque;
        public Tanque Tanque{
            set{tanque = value;}
        }
        public int CapacidadTanque
        {
            get{return this.tanque.CapacidadTanque;}
        }
        public int CombustibleRestante{
            get{return this.tanque.CombustibleRestante;}
        }

        public Vehiculo (Tanque tan){
            this.Tanque = tan;
        }

        public int reFuel(int fuel){
             int seCargo = this.tanque.reFuel(fuel);
             return seCargo;
        }

    }
}