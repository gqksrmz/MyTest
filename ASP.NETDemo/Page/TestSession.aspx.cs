using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo.Page
{
    public partial class TestSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> cart = new List<string>();
                Session["Cart"] = cart;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in form1.Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    if (chk.Checked)
                    {
                        ((List<string>)Session["cart"]).Add(chk.Text);
                    }
                }
            }
            this.btnAdd.Text = "添加成功！";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}