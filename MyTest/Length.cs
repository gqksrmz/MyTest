//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace mytest
//{
//    class length
//    {
//        static void Main(string[] args)
//        {
//            string s = "qweqweqwe";
//            int length = 12;
//            char c = '8';
//            Console.WriteLine("原来的字符串是：" + s + ";规定长度:" + length + "使用" + c + "来填充左侧，结果为:" + PadLeft(s, length, c));
//            Console.WriteLine("原来的字符串是：" + s + ";规定长度:" + length + "使用" + c + "来填充左侧，结果为:" + PadRight(s, length, c));
//        }
//        public static string PadLeft(string s, int length, char c)
//        {
//            string str = s;
//            if (s.Length < length)
//            {
//                for (int i = 0; i < length - s.Length; i++)
//                {
//                    str = c + str;
//                }
//            }
//            else
//            {
//                Console.WriteLine("字符串的长度已经等于或者超过" + length + "了，不需要填充。");
//            }
//            return str;
//        }
//        public static string PadRight(string s, int length, char c)
//        {
//            string str = s;
//            if (s.Length < length)
//            {
//                for (int i = 0; i < length - s.Length; i++)
//                {
//                    str = str + c;
//                }
//            }
//            else
//            {
//                Console.WriteLine("字符串的长度已经等于或者超过" + length + "了，不需要填充。");
//            }
//            return str;
//        }
//    }
//}
