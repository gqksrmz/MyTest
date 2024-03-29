﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSelectionSystem.Entity
{
    [Serializable]
    public class Course
    {
        private int _id;
        private string _coursename;
        private int _maxnum;
        private string _coursenum;
        public Course()
        {

        }
        public Course(int id,string coursename,int maxnum,string coursenum)
        {
            this._id = id;
            this._coursename = coursename;
            this._maxnum = maxnum;
            this._coursenum = coursenum;
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
            return this.Id.GetHashCode() + this.Coursename.GetHashCode()+this.Maxnum.GetHashCode()+this.Coursenum.GetHashCode();
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

        public string Coursename
        {
            get
            {
                return _coursename;
            }

            set
            {
                _coursename = value;
            }
        }

        public int Maxnum
        {
            get
            {
                return _maxnum;
            }

            set
            {
                _maxnum = value;
            }
        }

        public string Coursenum
        {
            get
            {
                return _coursenum;
            }

            set
            {
                _coursenum = value;
            }
        }
    }
}
