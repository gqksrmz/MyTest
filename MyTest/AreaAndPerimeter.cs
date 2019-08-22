//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public interface IFlyable { void Fly(); }
//    class AreaAndPerimeter
//    {
//    }
//    public class Constellation
//    {
//        public void Main(string[] args)
//        {
//            Shape circle = new Circle(5);
//            Console.WriteLine("圆的面积是{0},周长是{1}", circle.GetArea(), circle.GetPerimeter());
//            Shape square = new Square(10, 5);
//            Console.WriteLine("矩形的面积是{0},周长是{1}", square.GetArea(), square.GetPerimeter());
//            Console.ReadKey();
//        }
//    }
//    public abstract class Shape
//    {
//        public abstract double GetArea();
//        public abstract double GetPerimeter();
//    }
//    public class Circle : Shape
//    {
//        private double _r;
//        public double R
//        {
//            get { return _r; }
//            set { _r = value; }
//        }
//        public Circle(double r)
//        {
//            this.R = r;
//        }
//        public override double GetArea()
//        {
//            return Math.PI * this.R * this.R;
//        }
//        public override double GetPerimeter()
//        {
//            return 2 * Math.PI * this.R;
//        }
//    }
//    public  class Square : Shape
//    {
//        private double _height;
//        private double _width;
//        public Square(double height, double width)
//        {
//            this._height = height;
//            this._width = width;
//        }
//        public double Height
//        {
//            get { return _height; }
//            set { _height = value; }
//        }
//        public double Width
//        {
//            get { return _width; }
//            set { _width = value; }
//        }
//        public override double GetArea()
//        {
//            return this.Height * this.Width;
//        }
//        public override double GetPerimeter()
//        {
//            return (this.Height + this.Width) * 2;
//        }
//    }
//}
