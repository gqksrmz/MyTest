//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;

//namespace MyTest
//{
//    public class TestSerialize
//    {
//        static void Main(string[] args)
//        {
//            string path = Environment.CurrentDirectory + "\\fileperson.txt";
//            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
//            {
//                Person p = new Person("李华", 19);
//                BinaryFormatter bf = new BinaryFormatter();
//                bf.Serialize(fsWrite, p);
//            }
//            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
//            {
//                BinaryFormatter bf = new BinaryFormatter();
//                Person p = (Person)bf.Deserialize(fsRead);
//                Console.WriteLine(p.Name + " " + p.Age);
//            }
//        }
//    }
//    [Serializable]
//    public class Person
//    {
//        private string name;
//        private int age;
//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public string Name
//        {
//            get
//            {
//                return name;
//            }

//            set
//            {
//                name = value;
//            }
//        }

//        public int Age
//        {
//            get
//            {
//                return age;
//            }

//            set
//            {
//                age = value;
//            }
//        }
//    }
//}
