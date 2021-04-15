using System;
namespace EJERCICIO7_15543
{
    public interface IControlRemoto
    {
        int EstadoMotor{get;set;}
        int arrancarMotor();        
    }    
}