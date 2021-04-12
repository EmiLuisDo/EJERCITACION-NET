using System;
namespace EJERCICIO5_15308
{
    public class Sport : TipoConduccion{

        private int power =90;
        private int suspensionHeight =90;
        public int Power
        {
            get {return power;}
            set {power = value;}
        }
        public int SuspensionHeight 
        {
            get {return suspensionHeight;}
            set {suspensionHeight = value;}
        }

        
    }
}