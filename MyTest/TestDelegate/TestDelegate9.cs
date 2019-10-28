//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest.TestDelegate
//{
//    delegate Object ObjectRetriever();
//    class Test
//    {
//        static string RetrieveString() => "Hello World!";
//        static void Main(string[] args)
//        {
//            ObjectRetriever o = new ObjectRetriever(RetrieveString);
//            object result = o();
//            Console.WriteLine(result);//Hello World
//        }
//    }
//}
