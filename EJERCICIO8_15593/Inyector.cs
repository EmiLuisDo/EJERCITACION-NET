using System;
namespace EJERCICIO8_15593
{
    public static class Inyector
    {
        static void InyectarEstacionMedidorTemperatura(EstacionMetereologica estacion, MedidorTemperatura medidor)
        {
            estacion.setearMedidorTemperatura(medidor);
        }
    }
}