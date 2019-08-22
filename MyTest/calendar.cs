//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class Calendar
//    {
//        static void Main(string[] args)
//        {
//            string s = "   ";
//            Console.WriteLine("输入年份：");
//            int nYear = int.Parse(Console.ReadLine());
//            Console.WriteLine("请输入月份：");
//            int nMonth = int.Parse(Console.ReadLine());
//            DateTime day1 = new DateTime(nYear, nMonth, 1);
//            Console.WriteLine("日 一 二 三 四 五 六");
//            int week1 = (int)day1.DayOfWeek;//获取当月1号是星期几 星期几用数字表示
//            int lastday = day1.AddMonths(1).AddDays(-1).Day;
//            for (int i = 0; i < week1; i++)
//            {
//                Console.Write(s);
//            }
//            for (int i = 1; i <= lastday; i++)
//            {
//                Console.Write("{0:00} ", i);//按照01 02 输出
//                if ((i + week1) % 7 == 0)
//                {
//                    Console.WriteLine();
//                }
//            }
//            Console.WriteLine();

//        }
//    }
//}
