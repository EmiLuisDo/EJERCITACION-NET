using System;
namespace EJERCICIO4_15255
{
    public class Tanque{
        private int capacidadTanque;
        public int CapacidadTanque
        {
            get{return this.capacidadTanque;}
            set{capacidadTanque = value;}
        }
        private int combustibleRestante;
        public int CombustibleRestante{
            get{return combustibleRestante;}
            set{combustibleRestante=value;}
        }

        public Tanque(int capacidadTanque){
            this.CapacidadTanque=capacidadTanque;
            this.CombustibleRestante = 0;
        }

        //retorna la cantidad de combustibe que se cargó
        public int reFuel(int fuel){
            int seCargo = 0 ;
            int aCargar = espacioDisponible();
            if(aCargar > 0){
                if(fuel > aCargar){
                    CombustibleRestante = aCargar;
                    seCargo = aCargar;
                }
                else{
                    CombustibleRestante = fuel;
                    seCargo = fuel;
                }
            }
            return seCargo;
        }

        //retorna el espacio dispoible en el tanque
        private int espacioDisponible(){
            int espacio = 0;
            espacio = CapacidadTanque - CombustibleRestante ;
            return espacio;
        }

    }
}