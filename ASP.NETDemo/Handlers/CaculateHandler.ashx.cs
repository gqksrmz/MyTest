﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDemo.Handlers
{
    /// <summary>
    /// CaculateHandler 的摘要说明
    /// </summary>
    public class CaculateHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string num1 = context.Request.Params["num1"];
            string num2 = context.Request.Params["num2"];
            int result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            context.Response.Write(num1 + "+" + num2 + "=" + result);
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}