using System;
namespace EJERCICIO6_15441
{
    public class Tesla : AutoElectrico
    {

        public override int arrancar()
        {
            this.Estado = IVehiculo.encendido;
            Console.WriteLine ("Encendiendo Tesla");
            return this.Estado;
        }
        public Tesla(int id) : base(id){}
    }
}