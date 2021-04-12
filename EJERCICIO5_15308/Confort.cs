using System;
namespace EJERCICIO5_15308
{
    public class Confort:TipoConduccion{
        
        private int power = 23;
        private int suspensionHeight = 76;

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