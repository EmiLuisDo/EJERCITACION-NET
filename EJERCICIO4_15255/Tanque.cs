using System;
namespace EJERCICIO4_15255
{
    public class Tanque{
        private int capacidadTanque;
        public int CapacidadTanque
        {
            get{return this.capacidadTanque;}
            set{capacidadTanque = ValueTuple;}
        }
        private int combustibleRestante;
        public int CombustibleRestante{
            get{return combustibleRestante;}
            set{combustibleRestante=value;}
        }

        public Tanque(int capacidadTanque, int combustibleRestante){
            this.CapacidadTanque(capacidadTanque);
            this.CombustibleRestante(combustibleRestante);
        }

        //retorna la cantidad de combustibe que se cargó
        public int reFuel(int fuel){
            int seCargo = 0;
            if(hayEspacio()){
                int aCargar = fuel - (CapacidadTanque() - CombustibleRestante());;
                CombustibleRestante(aCargar);
                seCargo = fuel - aCargar;
            }
            return seCargo;
        }

        private bool hayEspacio(){
            bool espacio = false;
            if(CombustibleRestante() < CapacidadTanque() ){
                espacio = true;
            }
            return espacio;
        }

    }
}