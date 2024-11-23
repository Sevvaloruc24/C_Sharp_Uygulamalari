using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_SkalerÇarpım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("satır sayısı gir:");
            int satır=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sütun sayısı gir:");
            int sütun = Convert.ToInt32(Console.ReadLine());
            Random rnd= new Random();   
            int[,] matris=new int[satır,sütun];
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.Next(1,10);
                    Console.Write(matris[i,j]+" ");
                }
                Console.WriteLine();
            }
            int[,] sonuc = new int[satır, sütun];
            int skaler = 2;
            for(int i = 0;i < sonuc.GetLength(0); i++)
            {
                for(int j = 0;j < sonuc.GetLength(1); j++)
                {
                    sonuc[i, j] = matris[i,j]*skaler;
                    Console.Write(sonuc[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
