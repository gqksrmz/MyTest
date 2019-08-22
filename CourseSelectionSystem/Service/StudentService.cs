using CourseSelectionSystem.Dao;
using CourseSelectionSystem.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Service
{
    
    public class StudentService : StudentDao
    {
        List<Student> studentList = InputAndOutput.InputStudent();
        List<Course> courseList = InputAndOutput.InputCourse();
        Dictionary<Student, List<Course>> dic = InputAndOutput.InputSelectedCourse();
        Student stu= null;
        public bool ChangePassWord(string userpwd)
        {

            Student s1 = stu;
            s1.Userpwd = userpwd;
            studentList.Remove(stu);
            studentList.Add(s1);
            if (studentList.Contains(s1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeSelectedCourse(Course course)
        {
            List<Course> courses = dic.GetValueOrDefault(stu);
            courses.Remove(course);
            if (!courses.Contains(course))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        public bool Login(string username, string userpwd)
        {
            Student s = studentList.Find(x => x.Username == username&&x.Userpwd==userpwd);
            if (s != null)
            {
                stu = s;
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Course> OptionalCourse()//可选的课程
        {
            List<Course> optionalCourseList = new List<Course>();//返回的数组   
            List<Course> courses = dic.GetValueOrDefault(stu);//已选的  
            for (int i = 0; i < courseList.Count; i++)
            {
                if (!courses.Contains(courseList[i]))
                {
                    optionalCourseList.Add(courseList[i]);
                }
            }
            return optionalCourseList;

        }

        public List<Course> SearchAllCourse()
        {
            return courseList;
        }

        public List<Course> SearchSelectedCourse()
        {
            List<Course> courses = dic.GetValueOrDefault(stu);
            return courses;
        }

        public bool SelectCourse(Course course)
        {
            bool flag = false;
            foreach (KeyValuePair<Student,List<Course>> item in dic)
            {
                if (item.Key == stu)
                {
                    List<Course> courses = item.Value;
                    courses.Add(course);
                    if (courses.Contains(course))
                    {
                        flag=true;
                    }
                }
            }
            return flag;
        }
    }
}
