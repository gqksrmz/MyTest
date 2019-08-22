//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public class TestCreateObject
//    {
//        static void Main(string[] args)
//        {
//            CreateObject cb = new CreateObject();
//            cb.Sum = 5;
//            List<Object> list=cb.Create();
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//    public class CreateObject
//    {
//        private int sum;

//        public int Sum
//        {
//            get
//            {
//                return sum;
//            }

//            set
//            {
//                sum = value;
//            }
//        }
//        public List<Object> Create()
//        {
//            List<Object> list = new List<object>();
//            for (int i = 0; i < this.Sum; i++)
//            {
//                list.Add(new object());
//            }
//            return list;
//        }
//    }
//}
