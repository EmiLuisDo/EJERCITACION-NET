using System;
namespace EJERCICIO6_15441
{
    public class AutoCombustion : Vehiculo
    {
        private int id;
        public int Id
        {
            get {return id;}
            set {id = value;}
        }
        private int estado;
        public int Estado
        {
            get{return estado;}
            set{estado = value;}
        }

        public virtual int arrancar()
        {
            Console.WriteLine("Encendiendo AutoCombustion");
            this.Id = Vehiculo.encendido;
            return this.Id;
        }
        public AutoCombustion(int id){
            this.Id = id;
        }
    }
}