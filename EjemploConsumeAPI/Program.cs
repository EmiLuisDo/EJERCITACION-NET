using System;
using System.Net;
using Newtonsoft.Json;

namespace EjemploConsumeAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api-dolar-argentina.herokuapp.com/api/evolucion/dolaroficial";
            string json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);
            Console.WriteLine(json);
            Console.WriteLine(m);
            foreach(var obj in m.meses)
            {
                Console.WriteLine(obj.valor);
            }
        }
    }
}
