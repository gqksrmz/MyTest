using CourseSelectionSystem.Entity;
using CourseSelectionSystem.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Ui
{
    public class StudentUi
    {
        StudentService _studentService = new StudentService();


        public void StudentLogin()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入密码：");
            string userPwd = Console.ReadLine();
            bool loginStatus = _studentService.Login(userName.Trim(), userPwd);
            if (loginStatus == true)
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("登陆成功！");
                PrintStudentMenu();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("登陆失败!");
            }


        }

        private void PrintStudentMenu()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请选择：1.选择课程 2.查询可选 3.查看已选 4.修改选课 5.修改密码 ");
            Console.WriteLine("输入exit退出");
            Console.WriteLine("-----------------------------------------------------------------------------");
            string menuNum = Console.ReadLine();
            switch (menuNum)
            {
                case "1":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入要选择的课程名称：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string name = Console.ReadLine().Trim();
                    Course course = null;
                    List<Course> courseList = InputAndOutput.InputCourse();
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
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("选课成功！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("选课失败！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintStudentMenu();
                    break;
                case "2":
                    List<Course> optionalCourseList = _studentService.OptionalCourse();
                    if (optionalCourseList.Count > 0)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("课程序号   课程名称   最大人数   课程编号");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        foreach (var item in optionalCourseList)
                        {
                            Console.WriteLine("   {0}   {1}   {2}   {3}", item.Id, item.Coursename, item.Maxnum, item.Coursenum);
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("没有可选的课程！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintStudentMenu();
                    break;
                case "3":
                    List<Course> selectedCourse = _studentService.SearchSelectedCourse();
                    if ( selectedCourse==null)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("没有已选课程！快去选课学习！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("课程序号   课程名称   最大人数   课程编号");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        foreach (var item in selectedCourse)
                        {
                            if (item == null)
                            {
                                continue;
                            }
                            Console.WriteLine("   {0}   {1}   {2}   {3}", item.Id, item.Coursename, item.Maxnum, item.Coursenum);
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintStudentMenu();
                    break;
                case "4":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入要取消的课程编号：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string courNum = Console.ReadLine().Trim();
                    Course c = null;
                    List<Course> courses = _studentService.SearchSelectedCourse();
                    if (courses == null)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("没有选课，请先去选课！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        foreach (var item in courses)
                        {
                            if (item.Coursenum == courNum)
                            {
                                c = item;
                            }
                        }
                        bool f = _studentService.ChangeSelectedCourse(c);
                        if (f == true)
                        {
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("修改成功！");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("修改失败");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                        }
                    }
                    
                    PrintStudentMenu();
                    break;
                case "5":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入新的密码：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string userPass = Console.ReadLine().Trim();
                    bool flag = _studentService.ChangePassWord(userPass);
                    if (flag == true)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("修改成功！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("修改失败");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintStudentMenu();
                    break;
                case "exit":Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("输入错误！");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    break;
            }
        }
    }
}
