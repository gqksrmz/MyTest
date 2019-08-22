//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class StackAndQuequ
//    {

//        static void Main(string[] args)
//        {
//            Stack s = new Stack();
//            Stack<string> vs = new Stack<string>();//先进后出
//            vs.Push("awww");
//            vs.Push("aggg");
//            vs.Push("attt");
//            vs.Push("aee");
//            vs.Push("axx");
//            vs.Push("acc");
//            while (vs.Count > 0)
//            {
//                Console.WriteLine(vs.Pop());
//                Console.WriteLine("Count:" + vs.Count);
//            }
//            Queue queue = new Queue();
//            Queue<string> sq = new Queue<string>();//先进的先出
//            sq.Enqueue("1");
//            sq.Enqueue("2");
//            sq.Enqueue("3");
//            sq.Enqueue("4");
//            sq.Enqueue("5");
//            while (sq.Count > 0)
//            {
//                Console.WriteLine(sq.Dequeue());
//                Console.WriteLine("Count:" + sq.Count);
//            }

//        }
//    }
//}
