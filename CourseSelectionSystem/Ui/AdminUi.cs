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
            Console.WriteLine("请输入用户名：");
            string adminName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string adminPwd = Console.ReadLine();
            bool loginStatus = _adminService.Login(adminName.Trim(), adminPwd);
            if (loginStatus == true)
            {
                Console.WriteLine("登陆成功！");
                Console.WriteLine("请选择：1.查看所有课程 2.根据名称查询课程 3.课程删除 4.课程修改 5.课程新增");
                Console.WriteLine("请选择：6.查询所有学生 7.根据名字查询学生 8.学生删除 9.学生修改 10.增加学生");
                string adminMenuNum = Console.ReadLine();
                switch (adminMenuNum)
                {
                    case "1":
                        List<Course> courses = _adminService.SearchAllCourse();
                        Console.WriteLine("课程序号   课程名称   最大人数   课程编号");
                        foreach (var item in courses)
                        {
                            Console.WriteLine("{0}   {1}   {2}   {3}", item.Id, item.Coursename, item.Maxnum, item.Coursenum);
                        }
                        break;
                    case "2":
                        string str = Console.ReadLine();
                        Course course = _adminService.SearchSingleCourse(str.Trim());
                        Console.WriteLine("{0}   {1}   {2}   {3}", course.Id, course.Coursename, course.Maxnum, course.Coursenum);
                        break;
                    case "3":
                        Console.WriteLine("请输入课程编号:");
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
                            Console.WriteLine("删除成功");
                        }
                        else
                        {
                            Console.WriteLine("删除失败");
                        }
                        break;
                    case "4":
                        Console.WriteLine("请输入你要修改的课程的课程编号：");
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
                        Console.WriteLine("请输入你要修改的内容：1.课程序号  2.课程名称  3.最大人数");
                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                Console.WriteLine("请输入新的课程序号：");
                                changeCourse.Id = Convert.ToInt32(Console.ReadLine().Trim());
                                break;
                            case "2":
                                Console.WriteLine("请输入新的课程名称：");
                                changeCourse.Coursename = Console.ReadLine().Trim();
                                break;
                            case "3":
                                Console.WriteLine("请输入新的最大人数：");
                                changeCourse.Maxnum = Convert.ToInt32(Console.ReadLine().Trim());
                                break;
                            default:
                                Console.WriteLine("输入错误！");
                                break;
                        }
                        bool change = _adminService.ChangeCourseInfo(changeCourse);
                        if (change == true)
                        {
                            Console.WriteLine("修改成功！");
                        }
                        else
                        {
                            Console.WriteLine("修改失败！");
                        }
                        break;
                    case "5":
                        Course c = new Course();
                        Console.Write("请输入序号：");
                        int id = Convert.ToInt32(Console.ReadLine().Trim());
                        string courseName = Console.ReadLine().Trim();
                        int maxNum = Convert.ToInt32(Console.ReadLine().Trim());
                        string courseNum = Console.ReadLine().Trim();
                        c.Id = id;
                        c.Coursename = courseName;
                        c.Maxnum = maxNum;
                        c.Coursenum = courseNum;
                        bool status = _adminService.AddCourse(c);
                        if (status == true)
                        {
                            Console.WriteLine("添加成功");
                        }
                        else
                        {
                            Console.WriteLine("添加失败");
                        }
                        break;
                    case "6":
                        List<Student> students = _adminService.SearchAllStudnet();
                        Console.WriteLine("序号  姓名  用户名  密码  性别  学号  ");
                        foreach (var item in students)
                        {
                            Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", item.Id, item.Name, item.Username, item.Userpwd, item.Gender, item.Stunum);
                        }
                        break;
                    case "7":
                        string stustr = Console.ReadLine();
                        Student student = _adminService.SearchSingleStudent(stustr.Trim());
                        Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", student.Id, student.Name, student.Username, student.Userpwd, student.Gender, student.Stunum);
                        break;
                    case "8":
                        Console.WriteLine("请输入学生编号:");
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
                            Console.WriteLine("删除成功");
                        }
                        else
                        {
                            Console.WriteLine("删除失败");
                        }
                        break;
                    case "9":
                        Console.WriteLine("请输入你要修改的学生的学生编号：");
                        string strstu = Console.ReadLine().Trim();
                        Student changeStudent= null;
                        List<Student> stuList = _adminService.SearchAllStudnet();
                        foreach (var item in stuList)
                        {
                            if (item.Stunum == strstu)
                            {
                                changeStudent = item;
                            }
                        }
                        Console.WriteLine("请输入你要修改的内容：1.学生序号  2.姓名  3.用户名  4.密码  5.性别");
                        string num1 = Console.ReadLine();
                        switch (num1)
                        {
                            case "1":
                                Console.WriteLine("请输入新的学生序号：");
                                changeStudent.Id = Convert.ToInt32(Console.ReadLine().Trim());
                                break;
                            case "2":
                                Console.WriteLine("请输入新的学生姓名：");
                                changeStudent.Name = Console.ReadLine().Trim();
                                break;
                            case "3":
                                Console.WriteLine("请输入新的用户名：");
                                changeStudent.Username = Console.ReadLine().Trim();
                                break;
                            case "4":
                                Console.WriteLine("请输入新的密码：");
                                changeStudent.Userpwd = Console.ReadLine();
                                break;
                            case "5":
                                Console.WriteLine("请输入性别：");
                                changeStudent.Gender = Console.ReadLine().Trim();
                                break;
                            default:
                                Console.WriteLine("输入错误！");
                                break;
                        }
                        bool changeStu = _adminService.ChangeStuentInfo(changeStudent);
                        if (changeStu == true)
                        {
                            Console.WriteLine("修改成功！");
                        }
                        else
                        {
                            Console.WriteLine("修改失败！");
                        }
                        break;
                    case "10":
                        Student s = new Student();
                        Console.Write("请输入序号：");
                        int sid = Convert.ToInt32(Console.ReadLine().Trim());
                        string stuName = Console.ReadLine().Trim();
                        string userName = Console.ReadLine().Trim();
                        string userPwd = Console.ReadLine();
                        string sGender = Console.ReadLine().Trim();
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
                            Console.WriteLine("添加成功");
                        }
                        else
                        {
                            Console.WriteLine("添加失败");
                        }
                        break;
                    default:Console.WriteLine("输入错误！");
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
