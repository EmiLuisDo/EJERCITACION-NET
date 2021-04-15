using System;

namespace EJERCICIO7_15543
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto= new Auto(1);
            Console.WriteLine(auto);
            auto.arrancarMotor();
            Console.WriteLine(auto);
            auto.prenderRadio();
            Console.WriteLine(auto);
            auto.apagarRadio();
            Console.WriteLine(auto);

            Console.WriteLine("\n");
            
            Drone drone= new Drone(2);
            Console.WriteLine(drone);
            drone.arrancarMotor();
            Console.WriteLine(drone);
            drone.prenderCamara();
            Console.WriteLine(drone);
            drone.apagarCamara();
            Console.WriteLine(drone);
        }
    }
}
