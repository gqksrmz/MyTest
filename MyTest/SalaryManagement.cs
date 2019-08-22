//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class SalaryManagementSystem
//    {
//        static void Main(string[] args)
//        {
//            Employee[] employees = new Employee[4];
//            employees[0] = new SalariedEmployee("张三", "111-11-1111", 1975, 2, 5, 2000);
//            employees[1] = new SalariedEmployee("李四", "222-22-2222", 1978, 11, 25, 2222);
//            employees[2] = new HourlyEmplyee("王五", "333-33-3333", 1974, 6, 24, 20, 120);
//            employees[3] = new HourlyEmplyee("赵六", "444-44-4444", 1975, 8, 9, 30, 56);
//            for (int i = 0; i < employees.Length; i++)
//            {
//                employees[i].OutputInfo();
//            }
//        }
//    }
//    public class SalariedEmployee : Employee
//    {
//        private double _salary;
//        public SalariedEmployee(string name,string employeeid,int year,int month,int day,double salary)
//        {
//            this.Name = name;
//            this.EmployeeId = employeeid;
//            this.Year = year;
//            this.Month = month;
//            this.Day = day;
//            this.Salary = salary;
//        }
//        public double Salary
//        {
//            get { return _salary; }
//            set { _salary = value; }
//        }
//        public override void OutputInfo()
//        {
//            int m = DateTime.Now.Month;
//            if (m == Month)
//            {
//                Salary += 200;
//            }
//            Console.WriteLine("合同工" + this.Name + ",员工号：" + this.EmployeeId + "，生日:" + this.Year + "年" + this.Month + "月" + this.Day + "日,工资" + this.Salary);
//        }
//    }
//    public class HourlyEmplyee:Employee
//    {
//        private double _wage;
//        private double _hours;
//        public HourlyEmplyee(string name,string employeeid,int year,int month,int day,double wage,double hours)
//        {
//            this.Name = name;
//            this.EmployeeId = employeeid;
//            this.Year = year;
//            this.Month = month;
//            this.Day = day;
//            this.Wage = wage;
//            this.Hours = hours;
//        }
//        public double Wage
//        {
//            get { return _wage; }
//            set { _wage = value; }
//        }
//        public double Hours
//        {
//            get { return _hours; }
//            set { _hours = value; }
//        }
//        public override void OutputInfo()
//        {
//            int m = DateTime.Now.Month;
//            double salSum = this.Wage * this.Hours;
//            if (m == Month)
//            {
//                salSum += 200;
//            }
//            Console.WriteLine("小时工" + this.Name + ",员工号：" + this.EmployeeId + "，生日:" + this.Year + "年" + this.Month + "月" + this.Day + "日,工资" + salSum);
//        }
//    }
//    public class Employee
//    {
//        private string _name;
//        private string _employeeid;
//        private int _year;
//        private int _month;
//        private int _day;
//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }
//        public string EmployeeId
//        {
//            get { return _employeeid; }
//            set { _employeeid = value; }
//        }
//        public int Year
//        {
//            get { return _year; }
//            set { _year = value; }
//        }
//        public int Month
//        {
//            get { return _month; }
//            set { _month = value; }
//        }
//        public int Day
//        {
//            get { return _day; }
//            set { _day = value; }
//        }
//        public virtual void OutputInfo()
//        {

//        }
//    }
//}
