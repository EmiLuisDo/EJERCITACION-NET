using System;
namespace EJERCICIO8_15593
{
    public interface IEstacionMetereologica
    {
        public static readonly String temperatura = "Temperatura";
        void setearMedidorTemperatura(MedidorTemperatura medidorTemp);
    }
}