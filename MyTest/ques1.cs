//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class ques1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("请输入天数:");
//            string dayNum = Console.ReadLine();
//            int x = Convert.ToInt32(dayNum);
//            if (x > 365 || x < 1)
//            {
//                Console.WriteLine("输入的天数错误！");
//            }
//            int num = x % 7;
//            switch (num)
//            {
//                case 1:
//                    Console.WriteLine("今天是星期一");
//                    break;
//                case 2:
//                    Console.WriteLine("今天是星期二");
//                    break;
//                case 3:Console.WriteLine("今天是星期三");
//                    break;
//                case 4:
//                    Console.WriteLine("今天是是星期四");
//                    break;
//                case 5:Console.WriteLine("今天是星期五");
//                    break;
//                case 6:Console.WriteLine("今天是星期六");
//                    break;
//                case 7:
//                    Console.WriteLine("今天是星期天");
//                    break;
//            }
//            Console.ReadKey();
//        }
//    }

//}
