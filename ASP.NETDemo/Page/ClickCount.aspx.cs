using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo.Page
{
    public partial class ClickCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["count"]=0;
            }
        }

        protected void btnCount_Click(object sender, EventArgs e)
        {
            int count = (int)ViewState["count"];
            count++;
            this.text.Text = count.ToString();
            ViewState["count"] = count;
        }
    }
}