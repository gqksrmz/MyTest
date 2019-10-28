using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Entity
{
    [Serializable]
    public class Student
    {
        private int _id;
        private string _name;
        private string _username;
        private string _userpwd;
        private string _gender;
        private string _stunum;
        public Student()
        {

        }
        public Student(int id,string name,string username,string userpwd,string gender,string stunum)
        {
            this._id = id;
            this._name = name;
            this._username = username;
            this._userpwd = userpwd;
            this._gender = gender;
            this._stunum = stunum;
        }
        public override bool Equals(object obj)
        {
            if (this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode() + this.Name.GetHashCode() + this.Username.GetHashCode() + this.Userpwd.GetHashCode()+this.Gender.GetHashCode()+this.Stunum.GetHashCode();
        }
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Userpwd
        {
            get
            {
                return _userpwd;
            }

            set
            {
                _userpwd = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public string Stunum
        {
            get
            {
                return _stunum;
            }

            set
            {
                _stunum = value;
            }
        }
    }
}
