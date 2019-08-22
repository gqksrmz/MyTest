//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

//namespace MyTest
//{
//    public class AllTest
//    {
//        static void Main(string[] args)
//        {
//            string path = @"J:\test.txt";
//            using (FileStream fsWriter = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
//            {
//                string str = "Java是一门面向对象编程语言，不仅吸收了c++语言的各种优点，还摒弃了c++里难以理解的" +
//                    "多继承.指针等概念.....";
//                byte[] buffer = Encoding.Default.GetBytes(str);
//                fsWriter.Write(buffer, 0, buffer.Length);
//            }
//            using (FileStream fsReader = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
//            {
//                byte[] buffer = new byte[1024 * 1024 * 1];
//                int r = fsReader.Read(buffer, 0, 1024 * 1024 * 1);
//                string s = Encoding.Default.GetString(buffer, 0, r);
//                Console.WriteLine(s);

//            }
//            Console.WriteLine("写入成功！");
//            string newPath= @"J:\test1.txt";
//            File.Copy(path, newPath);
//            Console.WriteLine("文件复制成功！");
//        }
//    }

//}
