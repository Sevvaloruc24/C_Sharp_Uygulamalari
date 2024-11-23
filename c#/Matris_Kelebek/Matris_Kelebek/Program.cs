using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Kelebek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kare matrisin boyutlarını giriniz(n): ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[,] matris=new int[n,n];
            Random rnd= new Random();
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    matris[i, j] = rnd.Next(1, 10);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int top = 0;
            for (int j = 1; j <= (n / 2); j++)
            {
                for (int i = j; i <= n - (j + 1); i++)
                {
                    top += matris[i, j - 1] + matris[i, n - j];

                }
            }
            Console.WriteLine("toplam: "+top);
            Console.ReadKey();
        }
    }
}
