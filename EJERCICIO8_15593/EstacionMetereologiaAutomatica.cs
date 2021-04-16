using System;
using System.Collections.Generic;
namespace EJERCICIO8_15593
{
    public class EstacionMetereologicaAutomatica : EstacionMetereologica
    {
        private MedidorTemperatura medidorTemp;
        public MedidorTemperatura MedidorTemperatura
        {
            get{return medidorTemp;}
            set{medidorTemp = value;}
        }

        public Dictionary<string, double> obtenerReporte()
        {
            Dictionary<String, double> reporte= new Dictionary <String, double>();
            //...
            double temp = MedidorTemperatura.tomarTemperatura();
            reporte.Add(EstacionMetereologica.temperatura, temp);
            //...
            return reporte;
        }

        public EstacionMetereologicaAutomatica (MedidorTemperatura temp)
        {
            this.MedidorTemperatura = temp;
        }

        public EstacionMetereologicaAutomatica (){}

        public void setearMedidorTemperatura(MedidorTemperatura medidor)
        {
            this.MedidorTemperatura = medidor;
        }
    }
}