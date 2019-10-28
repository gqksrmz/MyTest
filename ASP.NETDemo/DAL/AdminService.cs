using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDemo.DAL
{
    public class AdminService
    {
        public bool AdminLogin(string username, string userpwd)
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
    }
}