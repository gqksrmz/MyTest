//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class CarRent
//    {
//        static void Main(string[] args)
//        {
//            KeChe kache = new KeChe(1, "卡车", 2000, 30);
//            HuoChe huoche = new HuoChe(1, "货车", 3000, 2000);
//            PiKa pika = new PiKa(2, "皮卡", 1000, 5, 2000);
//            Car[] cars = new Car[3];
//            cars[0] = kache;
//            cars[1] = huoche;
//            cars[2] = pika;
//            for (int i = 0; i < cars.Length; i++)
//            {
//                cars[i].GetInfo();
//            }
//        }


//    }
//    interface ZHL
//    {
//        int ZHL { get; set; }
//    }
//    interface ZKL
//    {
//        int ZKL { get; set; }
//    }
//    public class KeChe : Car, ZKL
//    {
//        private int zkl;
//        public KeChe(int id, string name, int money, int zkl) : base(id, name, money)
//        {
//            this.ZKL = zkl;
//        }
//        public int ZKL
//        {
//            get { return zkl; }
//            set { zkl = value; }
//        }

//        public override void GetInfo()
//        {
//            Console.WriteLine("名称是" + this.Name + " 租金" + this.Money);
//        }
//    }
//    public class HuoChe : Car, ZHL
//    {
//        private int zhl;
//        public HuoChe(int id, string name, int money, int zhl) : base(id, name, money)
//        {
//            this.ZHL = zhl;
//        }
//        public int ZHL
//        {
//            get { return zhl; }
//            set { zhl = value; }
//        }

//        public override void GetInfo()
//        {
//            Console.WriteLine("名称是" + this.Name + " 租金" + this.Money);
//        }
//    }
//    public class PiKa : Car, ZKL, ZHL
//    {
//        private int zhl;
//        private int zkl;
//        public PiKa(int id, string name, int money, int zkl, int zhl) : base(id, name, money)
//        {
//            this.ZKL = zkl;
//            this.ZHL = zhl;
//        }
//        public int ZKL
//        {
//            get { return zkl; }
//            set { zkl = value; }
//        }
//        public int ZHL
//        {
//            get { return zhl; }
//            set { zhl = value; }
//        }

//        public override void GetInfo()
//        {
//            Console.WriteLine("名称是" + this.Name + " 租金" + this.Money);
//        }
//    }
//    public abstract class Car
//    {
//        private int _id;
//        private string _name;
//        private int _money;
//        public Car()
//        {

//        }
//        public Car(int id, string name, int money)
//        {
//            this.Id = id;
//            this.Name = name;
//            this.Money = money;
//        }
//        public int Id
//        {
//            get { return _id; }
//            set { _id = value; }
//        }
//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }
//        public int Money
//        {
//            get { return _money; }
//            set { _money = value; }
//        }
//        public abstract void GetInfo();

//    }
//}
