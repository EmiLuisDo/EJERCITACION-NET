using System;
namespace EJERCICIO5_15308
{
    public static class Responsabilidad
    {
        public static void cambiarModo(Vehiculo veh, TipoConduccion tipoc){
            veh.TC = tipoc;
            veh.refrescarParametros();
        }
    }
}