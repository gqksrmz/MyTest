using CourseSelectionSystem.Entity;
using CourseSelectionSystem.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Ui
{
    public class AdminUi
    {
        AdminService _adminService = new AdminService();

        public void AdminLogin()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入用户名：");
            Console.WriteLine("-----------------------------------------------------------------------------");
            string adminName = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请输入密码：");
            Console.WriteLine("-----------------------------------------------------------------------------");
            string adminPwd = Console.ReadLine();
            bool loginStatus = _adminService.Login(adminName.Trim(), adminPwd);

            if (loginStatus == true)
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("登陆成功！");
                Console.WriteLine("-----------------------------------------------------------------------------");
                PrintMenu();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("登陆错误!");
                Console.WriteLine("-----------------------------------------------------------------------------");
            }


        }
        public void PrintMenu()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("请选择：1.查看所有课程 2.根据名称查询课程 3.课程删除 4.课程修改 5.课程新增");
            Console.WriteLine("请选择：6.查询所有学生 7.根据名字查询学生 8.学生删除 9.学生修改 10.增加学生");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("输入exit退出");
            string adminMenuNum = Console.ReadLine();
            switch (adminMenuNum)
            {
                case "1":
                    List<Course> courses = _adminService.SearchAllCourse();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("课程序号   课程名称   最大人数   课程编号");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    foreach (var item in courses)
                    { 
                        Console.WriteLine("   {0}   {1}   {2}   {3}", item.Id, item.Coursename, item.Maxnum, item.Coursenum);
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    PrintMenu();
                    break;
                case "2":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入课程名称:");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string str = Console.ReadLine();
                    Course course = _adminService.SearchSingleCourse(str.Trim());
                    Console.WriteLine("   {0}   {1}   {2}   {3}", course.Id, course.Coursename, course.Maxnum, course.Coursenum);
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    PrintMenu();
                    break;
                case "3":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入课程编号:");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string courserNum = Console.ReadLine().Trim();
                    Course delCourse = null;
                    List<Course> courseList = _adminService.SearchAllCourse();
                    foreach (var item in courseList)
                    {
                        if (item.Coursenum == courserNum)
                        {
                            delCourse = item;
                        }
                    }
                    bool statusDelCorse = _adminService.DeleteCourse(delCourse);
                    if (statusDelCorse == true)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("删除成功");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("删除失败");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintMenu();
                    break;
                case "4":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入你要修改的课程的课程编号：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string str1 = Console.ReadLine().Trim();
                    Course changeCourse = null;
                    List<Course> coursList = _adminService.SearchAllCourse();
                    foreach (var item in coursList)
                    {
                        if (item.Coursenum == str1)
                        {
                            changeCourse = item;
                        }
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入你要修改的内容：1.课程序号  2.课程名称  3.最大人数");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string num = Console.ReadLine();
                    switch (num)
                    {
                        case "1":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入新的课程序号：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeCourse.Id = Convert.ToInt32(Console.ReadLine().Trim());
                            break;
                        case "2":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入新的课程名称：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeCourse.Coursename = Console.ReadLine().Trim();
                            break;
                        case "3":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入新的最大人数：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeCourse.Maxnum = Convert.ToInt32(Console.ReadLine().Trim());
                            break;
                        default:
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("输入错误！");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            break;
                    }
                    bool change = _adminService.ChangeCourseInfo(changeCourse);
                    if (change == true)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("修改成功！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("修改失败！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintMenu();
                    break;
                case "5":
                    Course c = new Course();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入序号：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    int id = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入课程名称：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string courseName = Console.ReadLine().Trim();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入最大人数：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    int maxNum = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入课程编号：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string courseNum = Console.ReadLine().Trim();
                    c.Id = id;
                    c.Coursename = courseName;
                    c.Maxnum = maxNum;
                    c.Coursenum = courseNum;
                    bool status = _adminService.AddCourse(c);
                    if (status == true)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("添加成功");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("添加失败");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintMenu();
                    break;
                case "6":
                    List<Student> students = _adminService.SearchAllStudnet();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("序号  姓名  用户名  密码  性别  学号  ");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    foreach (var item in students)
                    {
                        Console.WriteLine("   {0}     {1}    {2}    {3}    {4}    {5}", item.Id, item.Name, item.Username, item.Userpwd, item.Gender, item.Stunum);
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    PrintMenu();
                    break;
                case "7":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入学生姓名：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string stustr = Console.ReadLine();
                    Student student = _adminService.SearchSingleStudent(stustr.Trim());
                    Console.WriteLine("   {0}     {1}    {2}    {3}    {4}    {5}", student.Id, student.Name, student.Username, student.Userpwd, student.Gender, student.Stunum);
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    PrintMenu();
                    break;
                case "8":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入学生编号:");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string stuNum = Console.ReadLine().Trim();
                    Student delStudent = null;
                    List<Student> studentList = _adminService.SearchAllStudnet();
                    foreach (var item in studentList)
                    {
                        if (item.Stunum == stuNum)
                        {
                            delStudent = item;
                        }
                    }
                    bool statusDelStudent = _adminService.DeleteStudent(delStudent);
                    if (statusDelStudent == true)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("删除成功");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("删除失败");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintMenu();
                    break;
                case "9":
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入你要修改的学生的学生编号：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string strstu = Console.ReadLine().Trim();
                    Student changeStudent = null;
                    List<Student> stuList = _adminService.SearchAllStudnet();
                    foreach (var item in stuList)
                    {
                        if (item.Stunum == strstu)
                        {
                            changeStudent = item;
                        }
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("请输入你要修改的内容：1.学生序号  2.姓名  3.用户名  4.密码  5.性别");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string num1 = Console.ReadLine();
                    switch (num1)
                    {
                        case "1":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入新的学生序号：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeStudent.Id = Convert.ToInt32(Console.ReadLine().Trim());
                            break;
                        case "2":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入新的学生姓名：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeStudent.Name = Console.ReadLine().Trim();
                            break;
                        case "3":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入新的用户名：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeStudent.Username = Console.ReadLine().Trim();
                            break;
                        case "4":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入新的密码：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeStudent.Userpwd = Console.ReadLine();
                            break;
                        case "5":
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("请输入性别：");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            changeStudent.Gender = Console.ReadLine().Trim();
                            break;
                        default:
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("输入错误！");
                            break;
                    }
                    bool changeStu = _adminService.ChangeStuentInfo(changeStudent);
                    if (changeStu == true)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("修改成功！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("修改失败！");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintMenu();
                    break;
                case "10":
                    Student s = new Student();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入序号：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    int sid = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入学生姓名：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string stuName = Console.ReadLine().Trim();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入用户名：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string userName = Console.ReadLine().Trim();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入密码：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string userPwd = Console.ReadLine();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入性别：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string sGender = Console.ReadLine().Trim();
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.Write("请输入学生编号：");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    string sNum = Console.ReadLine().Trim();
                    s.Id = sid;
                    s.Name = stuName;
                    s.Username = userName;
                    s.Userpwd = userPwd;
                    s.Gender = sGender;
                    s.Stunum = sNum;
                    bool stuStatus = _adminService.AddStudent(s);
                    if (stuStatus == true)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("添加成功");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("添加失败");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }
                    PrintMenu();
                    break;
                case "exit":
                    Environment.Exit(0);
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
