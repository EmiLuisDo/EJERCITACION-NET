using System;
using System.Threading.Tasks;

namespace EJERCICIO9_15794
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program.ejecutarMetodo1Async();
            Program.ejecutarMetodo2();
            Console.ReadKey();
        }

        static async Task ejecutarMetodo1Async()
        {
            for(int i=0; i<100; i++)
            {
                await Task.Run(() => 
                    imprimirMensaje()
                );
            }
        }

        private async static Task imprimirMensaje()
        {
            await Task.Delay(100);
            Console.WriteLine("Método1");
        }

        static void ejecutarMetodo2()
        {
            for(int i=0; i<25; i++)
            {
                Task.Delay(100).Wait();
                Console.WriteLine("Método2");
            }
        }
    }
}