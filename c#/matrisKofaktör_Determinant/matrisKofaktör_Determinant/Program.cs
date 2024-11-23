using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrisKofaktör_Determinant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matris boyutu (n) giriniz: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Random rnd= new Random();
            int[,] M= new int[n,n];
            Console.WriteLine("*****MATRİS ELEMANLARI*****");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    
                    Console.Write("M[{0},{1}]=",i,j);
                    M[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("*******MATRİS*******");
            for(int i = 0;i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(M[i, j]+" ");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine();
            Console.WriteLine("Determinat = {0}", Det_(M));

            Console.ReadKey();
        }

        static int Det_(int[,] matris)
        {
            int d = 0;
            int n=matris.GetLength(0);
            int[,] Alt_matris= new int[n-1,n-1];
            int alti = 0, altj = 0;
            if(n==1)
            {
               return matris[0,0];
            }
            else if(n==2)
            {
                return (matris[0, 0] * matris[1, 1] - matris[1, 0] * matris[0, 1]);
            }
            else
            {
                for (int k = 0; k < n; k++)
                { //-1^k
                    alti = 0;
                    for (int i = 1; i < n; i++)
                    {
                        altj = 0;
                        for (int j = 0; j < n; j++)
                        {
                            if (j == k) continue;
                            Alt_matris[alti, altj] = matris[i, j];
                            altj++;

                            /* if (j != k)
                             {
                                 AltMatris[alt_i, alt_j] = Matris[i, j];
                                 alt_j++;
                             }*/

                        }
                        alti++;
                    }
                    d = d + Convert.ToInt32(Math.Pow(-1, k)) * matris[0, k] * Det_(Alt_matris);
                }
            }
            return d;
        }
        int a = 0, b = 0, c = 0, x = 0;
        int Sonuc = 0;
        Console.WriteLine("denklemi giriniz: ");
            string denk = Console.ReadLine();
        //string denk = "1x^1 + 2x^2 + 3x^3 + 1x^4 = 2";
        string[] s = denk.Split('=');
        c = Convert.ToInt32(s[1].Trim());
            Console.WriteLine("c : {0}",c);
            string[] t = s[0].Split('+');
            for (int i = 0; i<t.Length; i++)
            {
                t[i] = t[i].Trim();
        Console.WriteLine(t[i]);
                string[] gecici = t[i].Split('x');
        a = Convert.ToInt32(gecici[0]);
                Console.WriteLine("a = "+a);
                string[] gecici1 = t[i].Split('^');
        b = Convert.ToInt32(gecici1[1]);
                Console.WriteLine("b = "+b);
                x = a + b;
                Sonuc += Convert.ToInt32(Math.Pow(x, c));
                Console.WriteLine("sonuç: {0}", Sonuc);
            }
    Console.WriteLine("sonuç: {0}",Sonuc);

            Console.ReadKey();
    }
}
