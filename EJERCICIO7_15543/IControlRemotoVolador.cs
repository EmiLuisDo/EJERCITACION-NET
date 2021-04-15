using System;
namespace EJERCICIO7_15543
{
    public interface IControlRemotoVolador
    {
        int EstadoCamara{get;set;}
        int prenderCamara();
        int apagarCamara();
    }
    
}