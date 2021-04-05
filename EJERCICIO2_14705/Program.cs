using System;

namespace EJERCICIO2_14705
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasajero pas1 = new Pasajero ("Emiliano", "Dominguez", new DateTime(1995, 6, 12), 312313, "Argentino");
            Pasajero pas2 = new Pasajero ("Nicolas", "Ibarra", new DateTime(1997, 2, 1), 3456, "Argentino");
            Pasajero pas3 = new Pasajero ("Carolina", "Dehle", new DateTime(1996, 3, 8), 45667, "Argentino");
            Pasajero pas4 = new Pasajero ("Hugo", "Fonseca", new DateTime(1992, 5, 9), 98476, "Argentino");
            Pasajero pas5 = new Pasajero ("Damian", "Arganiaras", new DateTime(1993, 4, 11), 98765, "Argentino");


            Avion avio = new Avion ("M Benz", "Hernandez", 100, "Panam");
            Vuelo vue = new Vuelo();
            vue.Avion = avio;
            vue.agregarPasajero(pas1);
            vue.agregarPasajero(pas2);
            vue.agregarPasajero(pas3);
            vue.agregarPasajero(pas4);
            vue.agregarPasajero(pas5);



            vue.despegar();
            vue.aterrizar();
        }
    }
}
