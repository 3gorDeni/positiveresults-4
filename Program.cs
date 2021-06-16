using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n, k;
            Console.WriteLine("строка");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("столбец");
            m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            Console.WriteLine("элементы");
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < m; j++)
                    Console.Write(arr[i, j] + " ");
            }
            int[] arr1 = new int[n * m];
            k = 0;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    if (arr[i, j] > 0)
                    {
                        arr1[k] = arr[i, j];
                        k++;
                    }
            Console.WriteLine("");
            Console.WriteLine("массив");
            if (k == 0)
                Console.WriteLine("Нет таких элеметов");
            else
                for (i = 0; i < k; i++)
                    Console.Write(arr1[i] + " ");
            Console.ReadKey();
        }
    }
}
