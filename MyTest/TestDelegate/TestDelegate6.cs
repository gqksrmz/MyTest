//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest.TestDelegate
//{
//    public delegate T Transformer<T>(T args);
//    public class Util
//    {
//        public static void Tranform<T> (T[] values,Transformer<T> t)
//        {
//            for (int i = 0; i < values.Length; i++)
//            {
//                values[i] = t(values[i]);
//            }
//        }
//        public class Test
//        {
//            static int Square(int x) => x * x;
//            static void Main(string[] args)
//            {
//                int[] values = { 1, 2, 3 };
//                Util.Tranform<int>(values, Square);
//                foreach (int i in values)
//                {
//                    Console.WriteLine(i+" ");
//                }
//            }
//        }
//    }
//}
