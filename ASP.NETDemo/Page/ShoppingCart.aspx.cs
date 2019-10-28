using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo.Page
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //取出对象集合，遍历后显示
            List<string> cart = (List<string>)Session["cart"];
            string info = string.Empty;
            foreach (string  item in cart)
            {
                info += item + " ";
            }
            Response.Write("你选择的商品为:" + info + "<br></br>");
            Response.Write("你的SessionID=" + Session.SessionID);
        }
    }
}