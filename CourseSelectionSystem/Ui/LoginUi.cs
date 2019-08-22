using CourseSelectionSystem.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Ui
{
    public class LoginUi
    {
        static void Main(string[] args)
        {
            LoginUi login = new LoginUi();
            login.Login();
        }
        StudentUi studentUi = new StudentUi();
        AdminUi adminUi = new AdminUi();
        public  void Login()
        {
            Console.WriteLine("欢迎使用学生选课系统!");
            Console.WriteLine("1：管理员登录  2：学生登录");
            string loginnum = Console.ReadLine();
            switch (loginnum)
            {
                case "1":
                    adminUi.AdminLogin();
                    break;
                case "2":
                    studentUi.StudentLogin();
                    break;
                default:Console.WriteLine("输入错误");
                    break;
            }
        }
    }
}
