//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public class TestAnimal
//    {
//        static void Main(string[] args)
//        {
//            Rabbit rabbit = new Rabbit("小白兔", "白色", "哺乳类");
//            Frog frog = new Frog("小青蛙", "绿色", "非哺乳类");
//            rabbit.Eat();
//            rabbit.Swim();
//            rabbit.GetInfo();
//            frog.Eat();
//            frog.Swim();
//            frog.GetInfo();
//        }
//    }
//    public abstract class Animal
//    {
//        private string name;
//        private string color;
//        private string type;
//        public Animal()
//        {

//        }
//        public Animal(string name,string color,string type)
//        {
//            this.name = name;
//            this.color = color;
//            this.type = type;
//        }
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public string Color
//        {
//            get { return color; }
//            set { color = value; }
//        }
//        public string Type
//        {
//            get { return type; }
//            set { type = value; }
//        }
//        public abstract void Eat();
//        public abstract void Bark();
//    }
//    public class Rabbit : Animal,ISwimable
//    {
//        public Rabbit(string name,string color,string type):base(name,color,type)
//        {

//        }
//        public override void Bark()
//        {
//            Console.WriteLine("兔子叫！");
//        }

//        public override void Eat()
//        {
//            Console.WriteLine("兔子吃东西！");
//        }

//        public void Swim()
//        {
//            Console.WriteLine("兔子游泳！");
//        }
//        public void GetInfo()
//        {
//            Console.WriteLine("我的名字是{0}，颜色是{1}，我是{2}动物", this.Name, this.Color, this.Type);
//        }
//    }
//    public class Frog : Animal,ISwimable
//    {
//        public Frog(string name, string color, string type) : base(name, color, type)
//        {

//        }
//        public override void Bark()
//        {
//            Console.WriteLine("青蛙叫！");
//        }

//        public override void Eat()
//        {
//            Console.WriteLine("青蛙吃东西！");
//        }

//        public void Swim()
//        {
//            Console.WriteLine("青蛙游泳！");
//        }
//        public void GetInfo()
//        {
//            Console.WriteLine("我的名字是{0}，颜色是{1}，我是{2}动物", this.Name, this.Color, this.Type);
//        }
//    }
//    interface ISwimable
//    {
//        void Swim();
//    }
//}
