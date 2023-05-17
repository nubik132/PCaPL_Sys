using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    class Лаб4_4
    {
        static public void Mass()
        {
            int[] myArr = new int[17];
            int[,] dvymer = new int[6,2];
            int[][] zyb = new int[3][];
            zyb[0] = new int[2];
            zyb[1] = new int[3];
            zyb[2] = new int[4];
            Random rnd = new();
            for (int i = 0; i < 17; i++)
            {
                myArr[i] = rnd.Next(17);
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dvymer[i,j] = rnd.Next(100);
                }
                
            }
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < zyb[i].Length; j++)
                {
                    zyb[i][j] = rnd.Next(100); 
                }
            }
            Console.WriteLine("Одномерный массив из 17 чисел:");     
            foreach (int x in myArr)
                Console.Write("{0} ", x);

            Console.WriteLine("\n\nДвумерный массив:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", dvymer[i,j]);
                }
                Console.WriteLine();
                    
            }
            Console.WriteLine("\n\nЗубчатый массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < zyb[i].Length; j++)
                {
                    Console.Write("{0} ", zyb[i][j]);
                }
                Console.WriteLine();
            }
            int SearchThree = Array.FindLastIndex(myArr, j => j == 3);
            Console.WriteLine("Индекс числа равного трем "+SearchThree);
            int[] LessThenTen = Array.FindAll(myArr, j => j < 10);
            Console.WriteLine("Числа меньше 10: ");
            foreach (int x in LessThenTen)
                Console.Write("{0} ", x);
        }
    }
}

    

