using System;
namespace EJERCICIO6_15441
{
    public class Audi:AutoCombustion
    {
        public override int arrancar()
        {
            this.Estado = IVehiculo.encendido;
            Console.WriteLine ("Encendiendo Audi");
            return this.Estado;
        }

        public Audi(int id): base(id){}
    }
}