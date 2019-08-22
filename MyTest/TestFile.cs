//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

//namespace MyTest
//{
//    public class TestFile
//    {
//        static void Main(string[] args)
//        {
//            string path = @"C:\Users\DELL\Desktop\数据库连接.txt";
//            string fullPath = getFullPath(path);
//            string fileName = getFileName(path);
//            string extenSion = getExtenSion(path);
//            string newpath = GetPath(path);
//            Console.WriteLine(fullPath);
//            Console.WriteLine(fileName);
//            Console.WriteLine(extenSion);
//            Console.WriteLine(newpath);
//        }
//        public static string GetFullPath(string str)
//        {
//            string path = Path.GetFullPath(str);
//            return path;
//        }
//        public static string GetPath(string str)
//        {
//            int index = str.LastIndexOf("\\");
//            string path = Path.GetFullPath(str).Substring(0, index);
//            return path;
//        }
//        public static string getFileName(string str)
//        {
//            string path = Path.GetFileName(str);
//            return path;
//        }
//        public static string getExtenSion(string str)
//        {
//            string path = Path.GetExtension(str);
//            if (string.IsNullOrEmpty(path))
//            {
//                return "";
//            }
//            return path;
//        }
//    }

//}
