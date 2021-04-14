using System;
namespace EJERCICIO6_15441
{
    public interface Vehiculo
    {
        public static int encendido = 0;
        public static int apagado = 0;

        int Id
        {
            get;
            set;
        }
        int Estado
        {
            get;
            set;
        }

        int arrancar();
    }
}