using CourseSelectionSystem.Entity;
using CourseSelectionSystem.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Ui
{
    public class StudentUi
    {
         StudentService _studentService=new StudentService();


        public void StudentLogin()
        {
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string userPwd = Console.ReadLine();
            bool loginStatus = _studentService.Login(userName.Trim(),userPwd);
            if (loginStatus == true)
            {
                Console.WriteLine("登陆成功！");
                Console.WriteLine("请选择：1.选择课程 2.查询可选 3.查看已选 4.修改选课 5.修改密码 ");
                string menuNum=Console.ReadLine();
                switch (menuNum)
                {
                    case "1":
                        Console.WriteLine("请输入要选择的课程名称：");
                        string name = Console.ReadLine().Trim();
                        Course course = null;
                        List<Course> courseList = new List<Course>();
                        foreach (var item in courseList)
                        {
                            if (item.Coursename == name)
                            {
                                course = item;
                            }
                        }
                        bool status = _studentService.SelectCourse(course);
                        if (status == true)
                        {
                            Console.WriteLine("选课成功！");
                        }
                        else
                        {
                            Console.WriteLine("选课失败！");
                        }
                        break;
                    case "2":
                        List<Course> optionalCourseList = _studentService.OptionalCourse();
                        Console.WriteLine("课程序号   课程名称   最大人数   课程编号");
                        foreach (var item in optionalCourseList)
                        {
                            Console.WriteLine("{0}   {1}   {2}   {3}", item.Id, item.Coursename, item.Maxnum, item.Coursenum);
                        }
                        break;
                    case "3":
                        List<Course> selectedCourse = _studentService.SearchSelectedCourse();
                        Console.WriteLine("课程序号   课程名称   最大人数   课程编号");
                        foreach (var item in selectedCourse)
                        {
                            Console.WriteLine("{0}   {1}   {2}   {3}", item.Id, item.Coursename, item.Maxnum, item.Coursenum);
                        }
                        break;
                    case "4":
                        Console.WriteLine("请输入要取消的课程名称：");
                        string courName = Console.ReadLine().Trim();
                        Course c = null;
                        List<Course> courses = _studentService.SearchSelectedCourse();
                        foreach (var item in courses)
                        {
                            if (item.Coursename == courName)
                            {
                                c = item;
                            }
                        }
                        bool f = _studentService.ChangeSelectedCourse(c);
                        if (f == true)
                        {
                            Console.WriteLine("修改成功！");
                        }
                        else
                        {
                            Console.WriteLine("修改失败");
                        }
                        break;
                    case "5":
                        Console.WriteLine("请输入新的密码：");
                        string userPass = Console.ReadLine().Trim();
                        bool flag = _studentService.ChangePassWord(userPass);
                        if (flag == true)
                        {
                            Console.WriteLine("修改成功！");
                        }
                        else
                        {
                            Console.WriteLine("修改失败");
                        }
                        break;
                    default:
                        Console.WriteLine("输入错误！");
                        break;
                }
            }
            else
            {
                Console.WriteLine("登陆失败!");
            }

            
        }
    }
}
