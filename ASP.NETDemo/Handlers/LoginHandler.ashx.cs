using ASP.NETDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDemo.Handler
{
    /// <summary>
    /// LoginHandler 的摘要说明
    /// </summary>
    public class LoginHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //获取前台网页提交的数据
            string userName = context.Request.Params["uname"];
            string userPwd = context.Request.Params["upwd"];
            //调用数据访问方法，判断用户名是否正确
            AdminService adminService = new AdminService();
            if (adminService.AdminLogin(userName, userPwd))
            {
                context.Response.Write("登陆成功！");
            }
            else
            {
                context.Response.Write("用户名或者密码错误！");
            }
            context.Response.Write("Hello World");
        }

        public bool IsReusable//是否自动缓存此对象以供下次使用
        {
            get
            {
                return false;
            }
        }
    }
}