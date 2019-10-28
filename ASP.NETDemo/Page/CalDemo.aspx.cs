using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo
{
    public partial class CalDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnCopy_Click(object sender, EventArgs e)
        {
            this.text2.Text = this.text1.Text;
        }
    }
}