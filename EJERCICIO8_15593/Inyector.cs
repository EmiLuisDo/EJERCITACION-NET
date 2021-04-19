using System;
namespace EJERCICIO8_15593
{
    public static class Inyector
    {
        static void InyectarEstacionMedidorTemperatura(IEstacionMetereologica estacion, MedidorTemperatura medidor)
        {
            estacion.setearMedidorTemperatura(medidor);
        }
    }
}