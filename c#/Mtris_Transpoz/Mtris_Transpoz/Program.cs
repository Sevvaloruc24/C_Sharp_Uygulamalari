using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtris_Transpoz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("satır gir:");
            int satır=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sütun gir:");
            int sütun = Convert.ToInt32(Console.ReadLine());
            Random rnd= new Random();
            int[,] matris = new int[satır, sütun];
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.Next(1, 10);
                    Console.Write(matris[i, j]+" ");
                }
                Console.WriteLine();
            }
            int[,] transpoz_matris = new int[sütun, satır];
            for(int i = 0; i < sütun; i++)
            {
                for(int j = 0;j<satır; j++)
                {
                    transpoz_matris[i, j] = matris[j, i];
                    Console.Write(transpoz_matris[i,j]+" ") ;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
