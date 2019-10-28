//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class TestDelegate
//    {
//        //    public delegate string DelProStr(string str);
//        //    static void Main(string[] args)
//        //    {
//        //        DelProStr del1 = StrToUpper;
//        //        string s1 = ProcessStr("abcdefg", StrToUpper);
//        //        Console.WriteLine(s1);
//        //        DelProStr del2 = StrToLower;
//        //        string s2 = ProcessStr("abcdefg", StrToLower);
//        //        Console.WriteLine(s2);
//        //        DelProStr del3 = StrToSYH;
//        //        string s3 = ProcessStr("abcdefg", StrToSYH);
//        //        Console.WriteLine(s3);
//        //    }
//        //    public static string ProcessStr(string str, DelProStr del)
//        //    {
//        //        string strNew = null;
//        //        char[] chs = str.ToCharArray();
//        //        for (int i = 0; i < chs.Length; i++)
//        //        {
//        //            strNew += del(chs[i].ToString());
//        //        }
//        //        return strNew;
//        //    }
//        //    public static string StrToUpper(string str)
//        //    {
//        //        return str.ToUpper();
//        //    }
//        //    public static string StrToLower(string str)
//        //    {
//        //        return str.ToLower();
//        //    }
//        //    public static string StrToSYH(string str)
//        //    {
//        //        return "\"" + str + "\"";
//        //    }

//        public delegate void ShowMsg(string msg);
//        public delegate int MathOperation(int a, int b);
//        public static ShowMsg showMsg;
//        static void Main(string[] args)
//        {
//            showMsg += SayHello1;
//            showMsg += SayHello2;
//            showMsg("大家新年好啊");
//            string str = "Hello World!";
//            char[] strChar = str.ToCharArray();
//            Array.Reverse(strChar);
//            foreach (var item in strChar)
//            {
//                Console.WriteLine(item + " ");
//            }

//        }
//        static void SayHello1(string msg)
//        {
//            Console.WriteLine("打招呼1：" + msg);
//        }
//        static void SayHello2(string msg)
//        {
//            Console.WriteLine("打招呼2：" + msg);
//        }

//    }
//}
