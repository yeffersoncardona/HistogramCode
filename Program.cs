using System;

namespace HistogramaCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] myArray =  { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };
            int n = myArray.Length;
            bool[] visited = new bool[n];
            int valor,valorold = 0;
            for (int i = 1; i <= 5; i++)
            {
               int count = 0;
                valor = i;
                for (int j = 0; j < n; j++)
                {
                    if (visited[j]==true)
                    {
                        continue;
                    }
                    if (myArray[j]==i)
                    {
                        visited[j] = true;
                        count++;
                    }
                }

                // La i tiene el valor y count las veces que se repite
                Console.Write(i + ": ");
                for (int k = 0; k < count; k++)
                {
                    Console.Write('*');
                }

                if (valor!=valorold)
                {
                    valorold = i;
                    Console.WriteLine();
                }
               
            }

          //  Console.Write();

            Console.ReadKey();
        }
    }
}
