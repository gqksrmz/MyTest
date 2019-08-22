using CourseSelectionSystem.Dao;
using CourseSelectionSystem.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Service
{   
    public class AdminService : AdminDao
    {
        List<Student> studentList = InputAndOutput.InputStudent();
        List<Course> courseList = InputAndOutput.InputCourse();
        public bool AddCourse(Course course)
        {
            courseList.Add(course);
            if (courseList.Contains(course))
            {
                InputAndOutput.OutPutCourse(courseList);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddStudent(Student student)
        {
            studentList.Add(student);
            if (studentList.Contains(student))
            {
                InputAndOutput.OutPutStudent(studentList);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeCourseInfo(Course course)
        {
            Course c=courseList.Find(x => x.Coursenum == course.Coursenum);
            courseList.Remove(c);
            courseList.Add(course);
            if (courseList.Contains(course))
            {
                InputAndOutput.OutPutCourse(courseList);
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool DeleteCourse(Course course)
        {
            courseList.Remove(course);
            if (courseList.Contains(course))
            {
                InputAndOutput.OutPutCourse(courseList);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DeleteStudent(Student student)
        {
            studentList.Remove(student);
            if (studentList.Contains(student))
            {
                InputAndOutput.OutPutStudent(studentList);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Login(string username, string userpwd)
        {
            if (username == "root" && userpwd == "root")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Course> SearchAllCourse()
        {
            return courseList;
        }

        public List<Student> SearchAllStudnet()
        {
            return studentList;
        }

        public Course SearchSingleCourse(string coursename)
        {
            Course course = courseList.Find(x => x.Coursename == coursename);
            if (course != null)
            {
                return course;
            }
            else
            {
                return null;
            }


        }

        public Student SearchSingleStudent(string stunum)
        {
            Student student = studentList.Find(x => x.Stunum== stunum);
            if (student != null)
            {
                return student;
            }
            else
            {
                return null;
            }

        }

        public bool ChangeStuentInfo(Student student)
        {

            Student c = studentList.Find(x =>x.Stunum==student.Stunum);
            studentList.Remove(c);
            studentList.Add(student);
            if (studentList.Contains(student))
            {
                InputAndOutput.OutPutStudent(studentList);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
