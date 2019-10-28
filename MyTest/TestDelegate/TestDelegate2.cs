//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public delegate int Transformer(int x);
//    public  class TestDelegate2
//    {
//         public static void Tranform(int[] values,Transformer t)
//        {
//            for (int i = 0; i < values.Length; i++)
//            {
//                values[i] =t(values[i]);
//            }
//        }
//    }
//    public  class Program
//    {
//        static int Square(int x) => x * x;
//        static void Main(string[] args)
//        {
//            int[] values = { 1, 2, 3 };
//            TestDelegate2.Tranform(values, Square);
//            foreach (int  i in values)
//            {
//                Console.WriteLine($"{i}");
//            }

//        }
//    }
//}
