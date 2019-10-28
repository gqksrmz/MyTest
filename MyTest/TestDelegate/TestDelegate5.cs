//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest.TestDelegate
//{
//    public delegate void ProgressReporter(int percentComplete);
//    class X
//    {
//        public void InstanceProgress(int percentComplete)
//            => Console.WriteLine(percentComplete);
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            X x = new X();
//            ProgressReporter p = x.InstanceProgress;
//            p(99);
//            Console.WriteLine(p.Target==x);//True
//            Console.WriteLine(p.Method);//Void InstanceProgress(Int32)
//        }
//    }
//}
