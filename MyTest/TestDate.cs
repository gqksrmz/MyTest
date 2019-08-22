//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class TestDate
//    {
//        static void Main(string[] args)
//        {
//            int year = 2019;
//            int month = 12;
//            int day = 31;

//            /* System.out.println("请输入年月日（空格隔开）：")
//            Scanner sc=new Scanner(System.in); */
//            Console.WriteLine("原日期是：" + year + "年" + month + "月" + day + "日");
//            if (month < 0 || month > 12)
//            {
//                Console.WriteLine("输入的月份有误");
//            }
//            if (day < 0 || day > 31)
//            {
//                Console.WriteLine("输入的日期有误");
//            }
//            nextDay(year, month, day);
//        }
//        public static void nextDay(int year, int month, int day)
//        {

//             if (day == 31&&month!=12)
//            {
//                month += 1;
//                day = 1;
//            }
//           else if (month == 12 && day == 31)
//            {      //判定有错误
//                year += 1;
//                month = 1;
//                day = 1;
//            }
//            else
//            {
//                day += 1;
//            }
//            Console.WriteLine("现日期是：" + year + "年" + month + "月" + day + "日");
//        }
//    }
//}
