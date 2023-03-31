using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace weblinq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataClasses1DataContext objdml = new DataClasses1DataContext();
            ////GridView1.DataSource = objdml.Students.ToList();
            ////GridView1.DataBind();
            //IEnumerable<Student> studlist = from s in objdml.Students
            //                                where s.name.Contains("s")
            //                                select s;
            //GridView1.DataSource =studlist.ToList();
            //GridView1.DataBind();

        }

      

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext objdml = new DataClasses1DataContext();
            //GridView1.DataSource = objdml.Students.ToList();
            //GridView1.DataBind();
            string x = TextBox1.Text;
            IEnumerable<Student> studlist = from s in objdml.Students
                                            where s.name.Contains(x)
                                            select s;
            GridView1.DataSource = studlist.ToList();
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext objdml = new DataClasses1DataContext();
            string x = DropDownList1.Text;
            IEnumerable<Student> studlist = from s in objdml.Students
                                            where s.city.Contains(x)
                                            select s;
            GridView1.DataSource = studlist.ToList();
            GridView1.DataBind();
        }
    }
}