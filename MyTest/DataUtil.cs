//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public class DataUtil
//    {
//        public void GetFirstDate(DateTime currentDate)
//        {
//            DateTime firstDayInMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
//            Console.WriteLine("本月第一天是"+firstDayInMonth);
//        }
//        public void GetLastDate(DateTime currentDate)
//        {
//            DateTime firstDayInMonth = new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(1).AddDays(-1);
//            Console.WriteLine("本月最后一天是" + firstDayInMonth);
//        }
//    }
//    public class Test
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("请输入年份：");
//            int year = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("请输入月份：");
//            int month = Convert.ToInt32(Console.ReadLine());
//            DateTime dt = new DateTime(year, month,1);
//            DataUtil du = new DataUtil();
//            du.GetFirstDate(dt);
//            du.GetLastDate(dt);
//        }
//    }
//}
