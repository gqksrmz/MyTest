//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;
//namespace MyTest
//{
//    class Test
//    {
//        static void Main(string[] args)
//        {
//            int[,] num = new int[9, 10];
//            int max = 0;
//            int min = 100;
//            int oldMaxI = 0;
//            int oldMaxJ = 0;
//            int oldMinI = 0;
//            int oldMinJ = 0;
//            for (int i = 0; i < 9; i++)
//            {
//                for (int j = 0; j < 10; j++)
//                {
//                    Random r = new Random();
//                    int n = r.Next(0, 100);
//                    num[i, j] = n;
//                }
//            }
//            Console.WriteLine("交换位置之前:");
//            for (int i = 0; i < 9; i++)
//            {
//                for (int j = 0; j < 10; j++)
//                {
//                    if (max < num[i, j])
//                    {
//                        max = num[i, j];
//                        oldMaxI = i;
//                        oldMaxJ = j;
//                    }
//                    if (min > num[i, j])
//                    {
//                        min = num[i, j];
//                        oldMinI = i;
//                        oldMinJ = j;
//                    }
//                    Console.Write(num[i, j] + " ");
//                }
//                Console.WriteLine("\n");
//            }
//            Console.WriteLine("原来最大值是{0},位于[{1},{2}]", max, oldMaxI, oldMaxJ);
//            Console.WriteLine("原来最小值是{0},位于[{1},{2}]", min, oldMinI, oldMinJ);
//            Console.WriteLine("交换位置之后:");
//            num[oldMaxI, oldMaxJ] = min;
//            num[oldMinI, oldMinJ] = max;
//            for (int i = 0; i < 9; i++)
//            {
//                for (int j = 0; j < 10; j++)
//                {
//                    if (max < num[i, j])
//                    {
//                        max = num[i, j];

//                    }
//                    if (min > num[i, j])
//                    {
//                        min = num[i, j];
//                    }
//                    Console.Write(num[i, j] + " ");
//                }
//                Console.WriteLine("\n");
//            }
//        }

//    }
//}
