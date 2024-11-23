using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Oluşturulacak matrisin satır sayısını giriniz:  ");
            int satır=Convert.ToInt32(Console.ReadLine());
            Console.Write("Oluşturulacak matrisin sütun sayısını giriniz:  ");
            int sütun = Convert.ToInt32(Console.ReadLine());
            Random rnd= new Random();
            int[,] matris=new int[satır,sütun];
            Console.WriteLine("*******MATRİS******");
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.Next(0, 10);
                    Console.Write(matris[i, j]+ " ");    
                }
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}
