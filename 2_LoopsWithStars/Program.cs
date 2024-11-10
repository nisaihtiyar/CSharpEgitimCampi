using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LoopsWithStars
{
    //Daha onceki konulari cokca dinledigim ve uyguladigim icin yazmadim. Sadece dinledim.
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 yildiz olusturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 yildiz olusturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Dik ucgen olusturma

            //for(int i = 1;i<=5; i++)
            //{
            //    for(int j=1;j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters dik ucgen

            //for (int i = 5; i >= 1; i--)    
            //{ 
            //    for(int j = 1; j <=i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Duz ve ters dik ucgeni ard arda yazdirma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 4; i>=1 ; i--)
            //{
            //    for (int j = 1; j <= i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for(int j= n-i;j>0; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k<=  2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //alt tarafi
            int m = 4;
            for(int i = m; i>=1; i--)
            {
                for (int j = m - i; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                for(int k = 1;k<= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion


            Console.Read();
        }
    }
}
