using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajaxdemo
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = ddl.SelectedValue.ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            TextBox2.Text = DateTime.Now.ToShortDateString().ToString();
        }
    }
}