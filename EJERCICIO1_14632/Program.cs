using System;

namespace Ejercicio1_14632
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avio = new Avion ("M Benz", "Hernandez", 100, "Panam");
            avio.encender();
            avio.aterrizar();
        }
    }
}
