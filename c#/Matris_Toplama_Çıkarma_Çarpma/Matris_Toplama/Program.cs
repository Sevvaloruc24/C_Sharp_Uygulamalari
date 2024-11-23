using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A matrisinin satır sayısını giriniz: ");
            int aSatır=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A matrisinin sütun sayısını giriniz: ");
            int aSütun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B matrisinin satır sayısını giriniz: ");
            int bSatır = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B matrisinin sütun sayısını giriniz: ");
            int bSütun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******A MATRİSİ******");
            int[,] a = matrisYaz_(aSatır, aSütun);

            Console.WriteLine("******B MATRİSİ******");
            int[,] b = matrisYaz_(bSatır, bSütun);

            //int[,] sonuc = new int[aSatır, aSütun];
            if(aSatır==bSatır&&aSütun==bSütun)
            {
                //int[,] sonuc = new int[aSatır, aSütun];
                Console.WriteLine("******TOPLAM MATRİS******");
                /*for(int i = 0; i < aSatır; i++)
                {
                    for (int j = 0; j < aSütun; j++)
                    {
                        sonuc[i,j]= a[i,j]+b[i,j];
                        Console.Write(sonuc[i,j]+" ");
                    }
                    Console.WriteLine();
                }*/
               int[,] sonuc = matrisTop_(a, b);
  
            }
            else
            {
                Console.WriteLine("BOYUT HATASI!!!");
            }
            if (aSatır == bSatır && aSütun == bSütun)
            {
                Console.WriteLine("******ÇIKARMA MATRİS******");

                int[,] sonuc2 = matrisCık_(a, b);
            }
            else
            {
                Console.WriteLine("BOYUT HATASI!!!");
            }
            if (aSatır == bSatır && aSütun == bSütun)
            {
                Console.WriteLine("******Çarpma MATRİS******");

                int[,] sonuc2 = matrisCarp_(a, b);
            }
            else
            {
                Console.WriteLine("BOYUT HATASI!!!");
            }




            Console.ReadKey();

        }
        static int[,] matrisYaz_(int satır, int sütun)
        {
            int[,] matris=new int[satır,sütun];
            Random rnd= new Random();   
            for (int i = 0;i<satır;i++)
            {
                for(int j = 0; j < sütun; j++)
                {
                    matris[i,j]=rnd.Next(0,10);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matris;
        }

        static int[,] matrisTop_(int[,] matris1, int[,] matris2)
        {
            int[,] matris = new int[matris1.GetLength(0), matris1.GetLength(1)];
            for (int i = 0; i < matris1.GetLength(0); i++)
            {
                for (int j = 0; j < matris1.GetLength(1); j++)
                {
                    matris[i, j] = matris1[i, j] + matris2[i,j];
                    Console.Write(matris[i, j]+" " ); 
                }
                Console.WriteLine();
            }
            return matris;
        }

        static int[,] matrisCık_(int[,] matris1, int[,] matris2)
        {
            int[,] matris = new int[matris1.GetLength(0), matris1.GetLength(1)];
            for (int i = 0; i < matris1.GetLength(0); i++)
            {
                for (int j = 0; j < matris1.GetLength(1); j++)
                {
                    matris[i, j] = matris1[i, j] - matris2[i, j];
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matris;
        }
        static int[,] matrisCarp_(int[,] matris1, int[,] matris2)
        {
            int[,] matris = new int[matris1.GetLength(0), matris1.GetLength(1)];
            for (int i = 0; i < matris1.GetLength(0); i++)
            {
                for (int j = 0; j < matris1.GetLength(1); j++)
                {
                    matris[i, j] = matris1[i, j] * matris2[i, j];
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matris;
        }
    }
}
