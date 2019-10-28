//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public delegate void ProgressReporter(int parcentComplete);
//    public class TestDelegate4
//    {

//    }
//    public class Util
//    {
//        public static void HardWork(ProgressReporter p)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                p(i * 10);//Invoke delegate
//                System.Threading.Thread.Sleep(100);
//            }
//        }
//    }
//    public class Test
//    {
//        static void Main(string[] args)
//        {
//            ProgressReporter p = WriteProgressToConsole;
//            p += WriteProgressToFile;
//            Util.HardWork(p);
//        }
//        static void WriteProgressToConsole(int percentComplete)
//            => Console.WriteLine(percentComplete);
//        static void WriteProgressToFile(int percentConsole)
//            => System.IO.File.AppendAllText("progress.txt", " "+percentConsole.ToString()+" ", Encoding.Default);
//    }
//}
