using CourseSelectionSystem.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CourseSelectionSystem
{
    public static class InputAndOutput
    {

        private static List<Course> courseList = new List<Course>();
        private static List<Student> studentList = new List<Student>();
        private static Dictionary<Student, List<Course>> dic = new Dictionary<Student, List<Course>>();
        public static Dictionary<Student, List<Course>> InputSelectedCourse()
        {
            using (FileStream fs = new FileStream(@"SelectedCourse.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                dic = (Dictionary<Student, List<Course>>)bf.Deserialize(fs);
            }
            return dic;
        }
        public static void OutPutSelectedCourse(Dictionary<Student, List<Course>> courses)
        {
            using (FileStream fs = new FileStream(@"SelectedCourse.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, courses);
            }
        }
        public static List<Course> InputCourse()
        {
            using (FileStream fs = new FileStream(@"Course.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                courseList = (List<Course>)bf.Deserialize(fs);
            }
            return courseList;
        }
        public static void OutPutCourse(List<Course> courses)
        {
            using (FileStream fs = new FileStream(@"Course.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, courses);
            }
        }

        public static List<Student> InputStudent()
        {
            using (FileStream fs = new FileStream(@"Course.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                studentList = (List<Student>)bf.Deserialize(fs);
            }
            return studentList;
        }
        public static void OutPutStudent(List<Student> students)
        {
            using (FileStream fs = new FileStream(@"Course.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, students);
            }
        }
    }
}
