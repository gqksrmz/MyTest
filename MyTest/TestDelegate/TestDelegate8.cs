//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest.TestDelegate
//{
//    delegate void StringAction(string s);
//    class Test
//    {
//        static void ActOnObject(object o) => Console.WriteLine(o);
//        static void Main()
//        {
//            StringAction sa = new StringAction(ActOnObject);
//            sa("Hello World!");
//        }
//    }
//}
