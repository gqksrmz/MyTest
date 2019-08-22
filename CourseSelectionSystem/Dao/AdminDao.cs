using CourseSelectionSystem.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Dao
{
    interface AdminDao
    {
        bool Login(string username, string userpwd);//登录
        bool AddStudent(Student student);//新增学生
        List<Student> SearchAllStudnet();//查询所有学生
        Student SearchSingleStudent(string stunum);//根据学生编号查询单个学生
        bool DeleteStudent(Student student);//删除学生
        bool ChangeStuentInfo(Student student);//修改学生信息

        bool AddCourse(Course course);//添加课程
        List<Course> SearchAllCourse();//查询所有课程
        Course SearchSingleCourse(string coursename);//根据课程名称查询单个课程
        bool DeleteCourse(Course course);//删除一个课程
        bool ChangeCourseInfo(Course course);//修改一个课程
    }
}
