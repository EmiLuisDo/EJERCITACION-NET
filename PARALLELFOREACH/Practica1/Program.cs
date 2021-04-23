using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practica1
{
    class Matriz
    {
        static void Main(string[] args)
        {
            int cantColumnasA = 1000, cantFilasB = 1000;
            int cantFilasA = 1000;
            int cantColumnasB = 1000;

            double [, ] mA = inicializarMatriz(cantFilasA, cantColumnasA);
            double [, ] mB = inicializarMatriz(cantFilasB, cantColumnasB);

            //double [, ] mA = {{2, 3}, {4, 5},{5, 6}}; 
            //double [, ] mB = {{5, 7, 3, 7}, {4, 2, 1, 2}}; 
            //imprimirMatriz(cantColumnasA, cantFilasA, mA);
            //imprimirMatriz(cantColumnasB, cantFilasB, mB);



            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //ejecutar multiplicacion secuencial 
            Double [,] resultP = muliplicarMatrizParalelo(mA, mB);
            //imprimirMatriz( cantColumnasB, cantFilasA, resultS);
            stopwatch.Stop();
            Console.Error.WriteLine("Tiempo for secuencial: {0}", stopwatch.ElapsedMilliseconds/1000);


            stopwatch.Reset();
            //ejecutar multiplicacion paralelo
            Console.WriteLine("Entro");
            Double [,] resultS = muliplicarMatrizSecuencial(mA, mB);
            Console.WriteLine("Salio");
            //imprimirMatriz( cantColumnasB, cantFilasA, resultP);
            stopwatch.Stop();
            Console.Error.WriteLine("Tiempo for secuencial: {0}", stopwatch.ElapsedMilliseconds/1000);


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
            Console.WriteLine("Filas result: "+resultado.GetLength(0).ToString()+", Columnas result: "+ resultado.GetLength(1).ToString());


            
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
