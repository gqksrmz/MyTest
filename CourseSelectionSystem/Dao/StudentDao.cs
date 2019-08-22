using CourseSelectionSystem.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Dao
{
    interface StudentDao
    {
        bool SelectCourse(Course course);//选择课程
        List<Course> SearchAllCourse();//查询所有课程
        bool Login(string username, string userpwd);//登录
        bool ChangePassWord(string userpwd);//修改密码
        List<Course> SearchSelectedCourse();//查看已选
        bool ChangeSelectedCourse(Course course);//修改选课(删除)
        List<Course> OptionalCourse();//查询可选的课程

    }
}
