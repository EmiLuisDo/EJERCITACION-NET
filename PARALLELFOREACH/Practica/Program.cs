using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practica
{
    class Matriz
    {
        static void Main(string[] args)
        {
            /*int cantColumnasA = 1500, cantFilasB = 1500;   //estas dos cantidades tienen que coincidir
            int cantFilasA = 1000;
            int cantColumnasB = 1000;
            //con estas lineas definimos el tamaño de las matrices a tratar, se pueden variar para probar el rendimiento del programa

            double [, ] mA = inicializarMatriz(cantFilasA, cantColumnasA);
            double [, ] mB = inicializarMatriz(cantFilasB, cantColumnasB);*/

            int cantColumnasA = 2, cantFilasB = 2;   //estas dos cantidades tienen que coincidir
            int cantFilasA = 3;
            int cantColumnasB = 4;
            double [, ] mA = {{2, 3}, {4, 5},{5, 6}}; 
            double [, ] mB = {{5, 7, 3, 7}, {4, 2, 1, 2}}; 
            imprimirMatriz(cantColumnasA, cantFilasA, mA);
            imprimirMatriz(cantColumnasB, cantFilasB, mB);
         //codigo para testear el funcionamiento del producto, crea dos matrices pequeñas de manera estatica si se usa comentar las dos líneas inicializarMatriz()


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //ejecutar multiplicacion secuencial 
            Double [,] resultS = muliplicarMatrizSecuencial(mA, mB);
            stopwatch.Stop();
            Console.Error.WriteLine("Tiempo for secuencial (segundos): {0}", stopwatch.ElapsedMilliseconds/1000);


            stopwatch.Reset();
            stopwatch.Start();
            //ejecutar multiplicacion paralelo
            Double [,] resultP = muliplicarMatrizParalelo(mA, mB);
            
            stopwatch.Stop();
            Console.Error.WriteLine("Tiempo for Paralelo (segundos): {0}", stopwatch.ElapsedMilliseconds/1000);

            imprimirMatriz( cantColumnasB, cantFilasA, resultP);

        }
        static double [,] muliplicarMatrizParalelo(double [, ] mA, double[, ] mB)
        {

            int filasA = mA.GetLength(0);
            int columnasA = mA.GetLength(1);
            int filasB = mB.GetLength(0);
            int columnasB = mB.GetLength(1);

            double temp;
            double[, ] resultado = new double[ filasA, columnasB];
            Parallel.For(0, filasA, i=>
                {
                    for(int j = 0; j < columnasB; j++)
                    {   
                        temp = 0;
                        for(int z=0; z < columnasA ; z++)
                        {
                            temp += (mA[i, z] * mB[z, j]);
                        }
                        resultado[i,j] = temp;
                    }
                });
            return resultado;
        }

        static double [,] muliplicarMatrizSecuencial(double [, ] mA, double[, ] mB)
        {

            int filasA = mA.GetLength(0);
            int columnasA = mA.GetLength(1);
            int filasB = mB.GetLength(0);
            int columnasB = mB.GetLength(1);


            double[, ] resultado = new double[ filasA, columnasB];
            //Console.WriteLine("Filas result: "+resultado.GetLength(0).ToString()+", Columnas result: "+ resultado.GetLength(1).ToString());


            double temp;
            for (int i = 0; i < filasA; i++)
            {
                for(int j = 0; j < columnasB; j++)
                {
                    temp = 0;
                    for(int z=0; z < columnasA ; z++)
                    {
                        temp += (mA[i, z] * mB[z, j]);
                    }
                    resultado[i,j] = temp;
                }
            }
            return resultado;
        }


        static double[,] inicializarMatriz(int cantFilas, int cantColumnas)
        {
            double [,] matriz = new double[cantFilas, cantColumnas];
            Random al = new Random();

            for(int i=0; i<cantFilas; i++)
            {
                for(int j = 0; j<cantColumnas; j++)
                {
                    matriz[i, j] = al.Next();
                }
            }
            return matriz;
        }









        //Método para verificar los resultados
        static void imprimirMatriz(int columnas, int filas,double[,] mat)
        {
            Console.WriteLine("----------------------------------------------Imprimiendo Matriz----------------------------------------------");
            for (int i = 0; i < filas; i++)
            {
                //Console.WriteLine("Imprimiendo fila:" +i);   
                String fila = "";
                for(int j=0; j<columnas; j++)
                {
                //    Console.WriteLine("Columna:" +j);   
                    fila += mat[i, j].ToString() + "\t";
                }
                Console.WriteLine(fila);
            }
            Console.WriteLine("--------------------------------------------------FIN Matriz-------------------------------------------------------");
        }
}
}
