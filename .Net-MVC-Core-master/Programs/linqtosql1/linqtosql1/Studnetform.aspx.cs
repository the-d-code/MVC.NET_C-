using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linqtosql1
{
    public partial class Studnetform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                fillgrid();
            }

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if(rollno.Text=="")
            {
                DataClasses1DataContext objcontext = new DataClasses1DataContext();
                Student std = new Student();
                std.Name = txtname.Text;
                std.Sem = Convert.ToInt32(DropDownList1.SelectedValue);
                std.Gender = RadioButtonList1.SelectedValue;
                std.Bdate = DateTime.Parse(TextBox1.Text);
                objcontext.Students.InsertOnSubmit(std);

                objcontext.SubmitChanges();
                fillgrid();

            }
            else
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                var st = dc.Students.Single(s => s.RollNo == Int16.Parse(rollno.Text));
                st.Name = txtname.Text;
                st.Sem = Convert.ToInt32(DropDownList1.SelectedValue);
                st.Gender= RadioButtonList1.SelectedValue;
                st.Bdate = DateTime.Parse(TextBox1.Text);
                dc.SubmitChanges();
                fillgrid();
            }
        }
        public void fillgrid()
        {
            DataClasses1DataContext OdContext = new DataClasses1DataContext();
            var courseTable = from course in OdContext.GetTable<Student>() select course;
            //odContext.Studenets.Select(x=>x);
            //grdCourse is gridview id
            GridView1.DataSource = courseTable;
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = e.RowIndex;
            int rno = Int16.Parse(GridView1.Rows[id].Cells[2].Text);
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var row = (from x in dc.Students where x.RollNo == rno select x).First();
            dc.Students.DeleteOnSubmit(row);
            dc.SubmitChanges();
            e.Cancel = true;
            fillgrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
          
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rno = Int16.Parse(GridView1.SelectedRow.Cells[2].Text);
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var row = (from x in dc.Students where x.RollNo == rno select x).First();
            rollno.Text = row.RollNo.ToString();
            txtname.Text = row.Name;
            DropDownList1.SelectedIndex = -1;
            DropDownList1.SelectedValue = row.Sem.ToString();
            RadioButtonList1.SelectedValue = row.Gender.ToString();
            TextBox1.Text = row.Bdate.ToString();
        }
    }
}