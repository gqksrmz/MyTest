using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo.Page
{
    public partial class TestApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.lit1.Text = "您是本网站第" + Application["UserVisit"].ToString() + "位访客!"
                    + "当前在线人数" + Application["CurrentUsers"].ToString();

            }
        }

        protected void btnC_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}