using CourseSelectionSystem.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CourseSelectionSystem
{
    public class Test
    {
        //static void Main(string[] args)
        //{

        //    #region Student
        //    List<Student> list1 = new List<Student>();
        //    Student student1 = new Student(1, "李磊", "root", "root", "男", "00001");
        //    Student student2 = new Student(2, "李华", "123456", "123456", "男", "00002");
        //    Student student3 = new Student(3, "李云龙", "root", "123456", "男", "00003");
        //    Student student4 = new Student(4, "燕双鹰", "sa", "123456", "男", "00004");
        //    Student student5 = new Student(5, "关二爷", "gqk", "gqk", "男", "00005");
        //    Student student6 = new Student(6, "李盼盼", "lpp", "lpp", "女", "00006");
        //    Student student7 = new Student(7, "宫庆凯", "gqk", "gqk", "男", "00007");
        //    Student student8 = new Student(8, "盖世张飞", "zf", "zf", "男", "00008");
        //    list1.Add(student1);
        //    list1.Add(student2);
        //    list1.Add(student3);
        //    list1.Add(student4);
        //    list1.Add(student5);
        //    list1.Add(student6);
        //    list1.Add(student7);
        //    list1.Add(student8);
        //    OutPutStudent(list1);
        //    #endregion
        //    #region Course
        //    List<Course> list2 = new List<Course>();
        //    Course course1 = new Course(1, "JAVA程序设计", 30, "HB001");
        //    Course course2 = new Course(2, "C++程序设计", 40, "HB002");
        //    Course course3 = new Course(3, "C#程序设计", 50, "HB003");
        //    Course course4 = new Course(4, "C语言程序设计", 60, "HB004");
        //    Course course5 = new Course(5, "Python程序设计", 70, "HB005");
        //    Course course6 = new Course(6, "计算机组成原理", 80, "HB006");
        //    Course course7 = new Course(7, "计算机网络", 90, "HB007");
        //    list2.Add(course1);
        //    list2.Add(course2);
        //    list2.Add(course3);
        //    list2.Add(course4);
        //    list2.Add(course5);
        //    list2.Add(course6);
        //    list2.Add(course7);
        //    OutPutCourse(list2);
        //    #endregion
        //    Dictionary<Student, List<Course>> dic = new Dictionary<Student, List<Course>>();

        //    dic.Add(student1, list2);
        //    dic.Add(student2, list2);
        //    dic.Add(student3, list2);
        //    dic.Add(student4, list2);
        //    dic.Add(student5, list2);
        //    dic.Add(student6, list2);
        //    dic.Add(student7, list2);
        //    dic.Add(student8, list2);
        //    OutPutSelectedCourse(dic);
        //}
        public static void OutPutSelectedCourse(Dictionary<Student, List<Course>> courses)
        {
            using (FileStream fs = new FileStream(@"SelectedCourse.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, courses);
            }
        }
        public static void OutPutCourse(List<Course> courses)
        {
            using (FileStream fs = new FileStream(@"Course.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, courses);
            }
        }
        public static void OutPutStudent(List<Student> students)
        {
            using (FileStream fs = new FileStream(@"Student.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, students);
            }
        }

    }
}
