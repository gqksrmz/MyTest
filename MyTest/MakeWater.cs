//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class MakeWater
//    {
//        static void Main(string[] args)
//        {
//            Water1 w1 = new Water1();
//            Water2 w2 = new Water2();
//            Water3 w3 = new Water3();
//            w1.MakeWater();
//            w2.MakeWater();
//            w3.MakeWater();
//            Console.ReadKey();
//        }
//    }
//    public class Water1 : Water, guolv, huanchong, jiare, fangtang
//    {
//        public void fangtang()
//        {
//            Console.WriteLine("放糖环节");
//        }

//        public void guolv()
//        {
//            Console.WriteLine("过滤环节");
//        }

//        public void huanchong()
//        {
//            Console.WriteLine("缓冲环节");
//        }

//        public void jiare()
//        {
//            Console.WriteLine("加热环节");
//        }

//        public override void MakeWater()
//        {
//            Console.WriteLine("生产水");
//            guolv();
//            huanchong();
//            jiare();
//            fangtang();
//            Console.WriteLine("\n");
//        }
//    }
//    public class Water2 : Water, guolv, huanchong, jiare
//    {
//        public void guolv()
//        {
//            Console.WriteLine("过滤环节");
//        }

//        public void huanchong()
//        {
//            Console.WriteLine("缓冲环节");
//        }

//        public void jiare()
//        {
//            Console.WriteLine("加热环节");
//        }

//        public override void MakeWater()
//        {
//            Console.WriteLine("生产水");
//            guolv();
//            huanchong();
//            jiare();
//            Console.WriteLine("\n");
//        }
//    }
//    public class Water3 : Water, guolv
//    {
//        public void guolv()
//        {
//            Console.WriteLine("过滤环节");
//        }

//        public override void MakeWater()
//        {
//            Console.WriteLine("生产水");
//            guolv();
//            Console.WriteLine("\n");
//        }
//    }
//    public abstract class Water
//    {
//        public abstract void MakeWater();
//    }
//    interface guolv
//    {
//        void guolv();
//    }
//    interface huanchong
//    {
//        void huanchong();
//    }
//    interface jiare
//    {
//        void jiare();
//    }
//    interface fangtang
//    {
//        void fangtang();
//    }
//}
