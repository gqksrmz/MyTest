using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace TrainTest
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string searchValue = context.Request.QueryString["searchvalue"];
            context.Response.ContentType = "text/plain";
            context.Response.Write(GetDataBaseData(searchValue));
        }
        public string GetDataBaseData(string searchvalue)
        {
            Database db = DatabaseFactory.CreateDatabase("ConnectionString");
            string strSql = "select name from Users where id='"+searchvalue+"'";
            DbCommand cmd = db.GetSqlStringCommand(strSql);
            var name = db.ExecuteScalar(cmd);
            if (name != null)
            {
                return name.ToString();
            }
            else
            {
                return null;
            }
            
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