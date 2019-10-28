//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public delegate int Transformer(int x);
//    public class TestDelegate3
//    {
//        static int Square(int x)
//        {
//            var result = x * x;
//            Console.WriteLine(result);
//            return result;
//        }
//        static int Cube(int x)
//        {
//            var result = x * x * x;
//            Console.WriteLine(result);
//            return result;
//        }
//        static void Main(string[] args)
//        {
//            //如果多播委托的返回类型不是void，那么调用者从最后一个
//            //被调用的方法来接受返回值，前面的方法仍然会被带调用，但是
//            //其返回值被弃用了
//            //所有的委托类型都派生于System.MulticastDelegate
//            //而它又派生于System.Delegate
//            //C#会把作用于委托的+，-，+=，-=操作
//            //编译成使用System.Delegate的Combine和Remove静态方法
//            Transformer t = null;
//            t += Square;
//            t += Cube;
            
//            var result = t(3);
//            Console.WriteLine(result);
//        }
//    }
//}
