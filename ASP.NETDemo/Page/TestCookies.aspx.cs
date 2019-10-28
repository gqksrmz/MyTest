using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo.Page
{
    public partial class TestCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //取出Cookie值
                if (Request.Cookies["str"] != null)
                {
                    Response.Write("字符串" + Request.Cookies["str"].Value);
                }
                if (Request.Cookies["userPhone"] != null)
                {
                    Response.Write("用户电话" + Request.Cookies["userPhone"].Value);
                }
            }
        }

        protected void btnSavaToCookies_Click(object sender, EventArgs e)
        {
            //第一种方法：保存到Cookies并设置有效期
            Response.Cookies["str"].Expires = DateTime.Now.AddDays(1.0);
            Response.Cookies["str"].Value= this.text.Text.Trim();
            //第二种方法
            HttpCookie httpCookie = new HttpCookie("userPhone", "17863270000");
            httpCookie.Expires = DateTime.Now.AddDays(1.0);
            Response.Cookies.Add(httpCookie);
        }
    }
}