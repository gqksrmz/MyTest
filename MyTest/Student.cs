//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public class Student
//    {
//        public static void Main(string[] args)
//        {
//            Student zsStudent = new Student(10001, "张三", 23, true, "0411-88888888");
//            zsStudent.ToString();
//            string str = "2019-07-25";
//            Console.WriteLine(str.Substring(8, 2));
//            Console.ReadKey();
//        }
//        private long id;
//        private string name;
//        private int age;
//        private bool sex;
//        private string phone;
//        public long Id
//        {
//            get { return id; }
//            set { id = value; }
//        }
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public int Age
//        {
//            get { return age; }
//            set { age = value; }
//        }
//        public bool Sex
//        {
//            get { return sex; }
//            set { sex = value; }
//        }
//        public string Phone
//        {
//            get { return phone; }
//            set { phone = value; }
//        }
//        public Student(long i, string n, int a, bool s, string p)
//        {
//            this.id = i;
//            this.name = n;
//            this.age = a;
//            this.sex = s;
//            this.phone = p;
//        }
//        public int GetAge()
//        {
//            return age;
//        }
//        public bool GetSex()
//        {
//            return sex;
//        }
//        public string GetPhone()
//        {
//            return phone;
//        }
//        public override string ToString()
//        {
//            return "姓名" + name + "联系电话" + phone + "学号" + id;
//        }
//    }
//}
