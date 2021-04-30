using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Practica
{
    class Matriz
    {
        static void Main(string[] args)
        {
            int cantColumnasA = 500, cantFilasB = 500;   //estas dos cantidades tienen que coincidir
            int cantFilasA = 500;
            int cantColumnasB = 500;
            //con estas lineas definimos el tamaño de las matrices a tratar, se pueden variar para probar el rendimiento del programa

            double [, ] mA = inicializarMatriz(cantFilasA, cantColumnasA);
            double [, ] mB = inicializarMatriz(cantFilasB, cantColumnasB);

            /*int cantColumnasA = 4, cantFilasB = 4;   //estas dos cantidades tienen que coincidir
            int cantFilasA = 5;
            int cantColumnasB = 4;
            double [, ] mA ={
                                {2, 3, 4,   6}, 
                                {4, 5, 93, 44},
                                {5, 6, 234, 43},
                                {10,80, 43, 444},
                                {34,56, 434, 44}
                            }; 
            double [, ] mB ={
                                {5, 7, 3, 7}, 
                                {4, 2, 1, 2}, 
                                {32, 322, 443, 222},
                                {12, 234, 21, 32222}, 
                                {1212, 435, 23, 543},
                                {222, 232, 122, 3333}, 
                            }; 
            
            imprimirMatriz(cantColumnasA, cantFilasA, mA);
            imprimirMatriz(cantColumnasB, cantFilasB, mB);*/
         //codigo para testear el funcionamiento del producto, crea dos matrices pequeñas de manera estatica si se usa comentar las dos líneas inicializarMatriz()


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //ejecutar multiplicacion secuencial 
            Double [,] resultS = muliplicarMatrizSecuencial(mA, mB);
            stopwatch.Stop();
            var tiempoSecuencial =  stopwatch.ElapsedMilliseconds/1000;

            stopwatch.Reset();
            stopwatch.Start();
            //ejecutar multiplicacion paralelo
            Double [,] resultP = muliplicarMatrizParalelo(mA, mB);
            
            stopwatch.Stop();
            Console.Error.WriteLine("Tiempo for secuencial (segundos): {0}", tiempoSecuencial);
            Console.Error.WriteLine("Tiempo for Paralelo (segundos): {0}", stopwatch.ElapsedMilliseconds/1000);

            //imprimirMatriz( cantColumnasB, cantFilasA, resultS);

        }
        static double [,] muliplicarMatrizParalelo(double [, ] mA, double[, ] mB)
        {

            int filasA = mA.GetLength(0);
            int columnasA = mA.GetLength(1);
            int filasB = mB.GetLength(0);
            int columnasB = mB.GetLength(1);

            double[, ] resultado = new double[ filasA, columnasB];
            Parallel.For(0, filasA, i=>
                {
                    //Console.WriteLine("thread" + Thread.CurrentThread.ManagedThreadId);
                    for(int j = 0; j < columnasB; j++)
                    {
                        resultado[i,j] = calcularElementoMatrizResultado(i, j, mA, mB, columnasA, columnasB);
                    }
                });
            return resultado;
        }

        static double calcularElementoMatrizResultado(int i, int j, double[,] mA, double[,] mB, int columnasA, int columnasB)
        {
            double temp = 0;
            for(int z=0; z < columnasA ; z++)
            {
                temp += (mA[i, z] * mB[z, j]);
            }
            return temp;
            
        }

        static double [,] muliplicarMatrizSecuencial(double [, ] mA, double[, ] mB)
        {

            int filasA = mA.GetLength(0);
            int columnasA = mA.GetLength(1);
            int filasB = mB.GetLength(0);
            int columnasB = mB.GetLength(1);


            double[, ] resultado = new double[ filasA, columnasB];
            //Console.WriteLine("Filas result: "+resultado.GetLength(0).ToString()+", Columnas result: "+ resultado.GetLength(1).ToString());

            for (int i = 0; i < filasA; i++)
            {
                //Console.WriteLine("thread" + Thread.CurrentThread.ManagedThreadId);
                for(int j = 0; j < columnasB; j++)
                {
                    resultado[i,j] = calcularElementoMatrizResultado(i, j, mA, mB, columnasA, columnasB);
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
