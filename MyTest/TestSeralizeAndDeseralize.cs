//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace MyTest
//{
//    public class TestSeralizeAndDeseralize
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Directory.GetParent(Environment.CurrentDirectory));
//            List<User> users = new List<User>();
//            users.Add(new User(1,"李华", "root", "管理员"));
//            users.Add(new User(2, "李雷", "root", "用户"));
//            users.Add(new User(3, "李蕾", "root", "用户"));
//            users.Add(new User(4, "李磊", "root", "用户"));
//            using (FileStream fs=new FileStream(@"user.txt",FileMode.OpenOrCreate,FileAccess.Write))
//            {
//                BinaryFormatter bf = new BinaryFormatter();
//                bf.Serialize(fs, users);
//            }
//            using (FileStream fs=new FileStream(@"user.txt",FileMode.OpenOrCreate,FileAccess.Read))
//            {
//                BinaryFormatter bf = new BinaryFormatter();
//                List<User> userList=(List<User>)bf.Deserialize(fs);
//                foreach (var item in userList)
//                {
//                    Console.WriteLine("id:{0},name:{1},password:{2},type:{3}", item.Id, item.Name, item.Password, item.Type);
//                }
//            }
//        }
//    }
//    [Serializable]
//    public class User
//    {
//        private int id;
//        private string name;
//        private string password;
//        private string type;
//        public User()
//        {

//        }
//        public User(int id,string name,string password,string type)
//        {
//            this.id = id;
//            this.name = name;
//            this.password = password;
//            this.type = type;
//        }
//        public int Id
//        {
//            get { return id; }
//            set { id = value; }
//        }
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public string Password
//        {
//            get { return password; }
//            set { password = value; }
//        }
//        public string Type
//        {
//            get { return type; }
//            set { type = value; }
//        } 
//    }
//}
