using System;
namespace EJERCICIO6_15441
{
    public class AutoElectrico : Vehiculo
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
            Console.WriteLine("Encendiendo AutoElectrico");
            this.Id = Vehiculo.encendido;
            return this.Id;
        }

        public AutoElectrico(int id){
            this.Id = id;
        }
    }
}