using System;
namespace EJERCICIO2_14705
{
    class Avion{
        private String marca;
        private String piloto;
        private int capacidadPasajeros;
        private String aerolinea;
        public void encender(){
            Console.WriteLine("El avion ha despegado!");
        }
        public void aterrizar(){
            Console.WriteLine("El avion ha aterrizado!");
        }
        public Avion (String marca, String piloto, int capacidadPasajeros, String aerolinea){
            this.marca = marca;
            this.piloto=piloto;
            this.capacidadPasajeros = capacidadPasajeros;
            this.aerolinea = aerolinea;
        }
    }

}