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
        Student stu = null;
        public bool ChangePassWord(string userpwd)
        {

            Student s1 = stu;
            s1.Userpwd = userpwd;
            studentList.Remove(stu);
            studentList.Add(s1);
            if (studentList.Contains(s1))
            {
                stu = s1;
                InputAndOutput.OutPutStudent(studentList);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeSelectedCourse(Course course)
        {
            List<Course> courses = null;
            Student s = null;
            foreach (KeyValuePair<Student, List<Course>> item in dic)
            {
                if (item.Key.Equals(stu))
                {
                    courses = item.Value;
                    courses.Remove(course);
                    s = item.Key;
                }
            }
            if (!courses.Contains(course))
            {
                dic[s] = courses;
                InputAndOutput.OutPutSelectedCourse(dic);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Login(string username, string userpwd)
        {
            Student s = studentList.Find(x => x.Username == username && x.Userpwd == userpwd);
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
            List<Course> courses = null;//已选的  
            foreach (KeyValuePair<Student, List<Course>> item in dic)
            {
                
                if (item.Key.Equals(stu))
                {
                    courses = item.Value;
                }
            }
            if (courses == null)
            {
                return courseList;
            }
            else
            {
                for (int i = 0; i < courseList.Count; i++)
                {
                    if (!courses.Contains(courseList[i]))
                    {
                        optionalCourseList.Add(courseList[i]);
                    }
                }
                return optionalCourseList;
            }
        }

        public List<Course> SearchAllCourse()
        {
            return courseList;
        }

        public List<Course> SearchSelectedCourse()
        {
            List<Course> courses = null;
            foreach (KeyValuePair<Student, List<Course>> item in dic)
            {
                if (item.Key.Equals(stu))
                {
                    courses = item.Value;
                }
            }
            return courses;
        }

        public bool SelectCourse(Course course)
        {
            Student s = null;
            List<Course> courses = new List<Course>();
            foreach (KeyValuePair<Student, List<Course>> item in dic)
            {
                if (item.Key.Equals(stu))
                {
                    courses = item.Value;
                    courses.Add(course);
                    s = item.Key;
                }
            }
            if (courses.Count<=0)
            {
                courses.Add(course);
                dic.Add(stu, courses);
                if (courses.Contains(course))
                {
                    InputAndOutput.OutPutSelectedCourse(dic);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (courses.Contains(course))
                {
                    dic[s] = courses;
                    InputAndOutput.OutPutSelectedCourse(dic);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

        }
    }
}
