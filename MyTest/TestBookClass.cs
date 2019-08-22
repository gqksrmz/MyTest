//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public class TestBookClass
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, Book> dic = new Dictionary<string, Book>();
//            dic.Add("book1", new Book("SB001", "大头儿子小头爸爸", 45.56, "维基百科"));
//            dic.Add("book2", new Book("NB004", "西游记", 189.98, "四大名著"));
//            dic.Add("book3", new Book("NB008", "熊出没", 35.67, "百度百科"));
//            foreach (KeyValuePair<string ,Book> item in dic)
//            {
//                Console.WriteLine(item.Key);
//                Book b = item.Value;
//                Console.WriteLine("书籍信息:" + b.Id + " " + b.Name + " " + b.Price + " " + b.Type);
//            }
//        }
//    }
//    public class Book
//    {
//        private string id;
//        private string name;
//        private double price;
//        private string type;
//        public Book()
//        {

//        }
//        public Book(string id,string name,double price,string type)
//        {
//            this.Id = id;
//            this.Name = name;
//            this.Price = price;
//            this.Type = type;
//        }

//        public string Id
//        {
//            get
//            {
//                return id;
//            }

//            set
//            {
//                id = value;
//            }
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

//        public double Price
//        {
//            get
//            {
//                return price;
//            }

//            set
//            {
//                price = value;
//            }
//        }

//        public string Type
//        {
//            get
//            {
//                return type;
//            }

//            set
//            {
//                type = value;
//            }
//        }
//    }
//}
