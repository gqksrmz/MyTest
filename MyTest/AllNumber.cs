//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace MyTest
//{
//    class AllNumber
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("请输入边长:");
//            int x = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("请输入边长:");
//            int y = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("请输入边长:");
//            int z = Convert.ToInt32(Console.ReadLine());
//            Triangle triangle = new Triangle(x, y, z);
//            triangle.GetInfo();
//            triangle.GetArea();
//        }
//    }
//    public class Triangle
//    {
//        private double _x, _y, _z;
//        public Triangle(double x, double y, double z)
//        {
//            this.X = x;
//            this.Y = y;
//            this.Z = z;
//        }
//        public double X
//        {
//            get { return _x; }
//            set { _x = value; }
//        }
//        public double Y
//        {
//            get { return _y; }
//            set { _y = value; }
//        }
//        public double Z
//        {
//            get { return _z; }
//            set { _z = value; }
//        }
//        public void GetInfo()
//        {
//            try
//            {
//                if (X + Y <= Z || X + Z <= Y || Z + Y <= X)
//                {
//                    throw new MyException();
//                }
//                else
//                {
//                    Console.WriteLine("三角形的三个边长分别是:{0},{1},{2}", X, Y, Z);
//                }
//            }
//            catch (MyException ex)
//            {
//                ex.throwE();
//            }


//        }
//        public void GetArea()
//        {
//            try
//            {

//                if (X + Y <= Z || X + Z <= Y || Z + Y <= X)
//                {
//                    throw new MyException();

//                }
//                else
//                {
//                    double p = (X + Y + Z) / 2;
//                    double s = Math.Sqrt(p * (p - X) * (p - Y) * (p - Z));
//                    Console.WriteLine("三角形的面积是:" + s);
//                }
//            }
//            catch (MyException ex)
//            {
//                ex.throwE();
//            }



//        }
//    }
//    public class MyException : Exception
//    {
//        public void throwE()
//        {
//            Console.WriteLine("这三条边构不成三角形");
//        }
//    }
//}
