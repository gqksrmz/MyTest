//using System;
//namespace x
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Student s1 = new Student("李华", 21, '男', 100, 98, 87);
//            Console.WriteLine("我叫{0},我今年{1}岁,我是{2}生,总分是{3},平均分是{4}", s1.Name, s1.Age, s1.Gender, s1.Math + s1.English + s1.Chinese, (s1.Math + s1.English + s1.Chinese) / 3);
//            Student s2 = new Student("李磊", 59, 60, 62);
//            Console.WriteLine("我叫{0},我今年{1}岁,我是{2}生,总分是{3},平均分是{4}", s2.Name, s2.Age, s2.Gender, s2.Math + s2.English + s2.Chinese, (s2.Math + s2.English + s2.Chinese) / 3);
//            Student s = new Student();
//            Person p = new Student();
//            Student P = (Student)p;
//            P.SayHello();
//            if(s is Student)
//            {
//                Console.WriteLine("你好");
//            }
//            Console.ReadKey();
//        }
//    }
//    public class Person
//    {
//        public void SayHello()
//        {
//            Console.WriteLine("你好啊,这是父类");
//        }
//    }
//    public class Student : Person
//    {
//        public  void SayHello()
//        {
//            Console.WriteLine("你好啊,这是子类");
//        }
//        public Student ()
//        {

//        }
//        public Student(string name, int age, char gender, int math, int english, int chinese)
//        {
//            this.Name = name;
//            this.Age = age;
//            this.Gender = gender;
//            this.Math = math;
//            this.English = english;
//            this.Chinese = chinese;
//        }
//        public Student(string name, int math, int english, int chinese) : this(name, 22, '男', math, english, chinese)
//        {
             
//        }
//        private string _name;
//        private int _age;
//        private char _gender;
//        private int _math;
//        private int _english;
//        private int _chinese;

//        public string Name { get => _name; set => _name = value; }
//        public int Age { get => _age; set => _age = value; }
//        public char Gender { get => _gender; set => _gender = value; }
//        public int Math { get => _math; set => _math = value; }
//        public int English { get => _english; set => _english = value; }
//        public int Chinese { get => _chinese; set => _chinese = value; }
//    }
     

//}