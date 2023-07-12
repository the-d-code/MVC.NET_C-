using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplication4.Models;
using Newtonsoft.Json;

namespace WebApplication4.Controllers
{
    public class UserMasterController : Controller
    {
        // GET: UserMaster

        private SqlConnection con;
         private void connection()
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\sem7\.net\Programs\WebApplication4\WebApplication4\App_Data\Demo.mdf;Integrated Security=True";
            con = new SqlConnection(connectionstring);
        }
        public ActionResult Index()
        {
            return View();

           
        }
        public ActionResult Add(userModel master)
        {
            connection();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = null;
            SqlTransaction transaction = con.BeginTransaction();
           
            try
            {
                if(master.id == 0)
                {
                    cmd = new SqlCommand("insertUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fname", master.Fname);
                    cmd.Parameters.AddWithValue("@Lname", master.Lname);
                    cmd.Parameters.AddWithValue("@Username", master.Username);
                    cmd.Parameters.AddWithValue("@password", master.password);
                    cmd.Parameters.AddWithValue("@ID", SqlDbType.Int);
                    cmd.Parameters["@ID"].Direction = ParameterDirection.Output;

                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    var id = Int16.Parse(cmd.Parameters["@ID"].Value.ToString());
                    //transaction.Commit();

                    SqlCommand cmd1 = null;
                    foreach (var i in master.Markslist)
                    {
                        cmd1 = new SqlCommand("insertMarks", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Marks1", i.Marks1);
                        cmd1.Parameters.AddWithValue("@Marks2", i.Marks2);
                        cmd1.Parameters.AddWithValue("@Marks3", i.Marks3);
                        cmd1.Parameters.AddWithValue("@Total", i.Total);
                        cmd1.Parameters.AddWithValue("@Percentage", i.Percentage);
                        cmd1.Parameters.AddWithValue("@Id", id);
                        cmd1.Transaction = transaction;
                        cmd1.ExecuteNonQuery();
                       
                    }


                    
                    transaction.Commit();
                    con.Close();

                    return Json(new { status = "Success" }, JsonRequestBehavior.AllowGet);

                }
                else
                {
                    cmd = new SqlCommand("Updatedata", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", master.id);
                    cmd.Parameters.AddWithValue("@Fname", master.Fname);
                    cmd.Parameters.AddWithValue("@Lname", master.Lname);
                    cmd.Parameters.AddWithValue("@Username", master.Username);
                    cmd.Parameters.AddWithValue("@password", master.password);
                    cmd.Transaction = transaction;
                    var id = cmd.ExecuteScalar();
                    transaction.Commit();
                    con.Close();
                    return Json(new { status = "Success" }, JsonRequestBehavior.AllowGet);

                }

            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception EX2)
                {

                    return Json(new { status = "Fail", error = EX2.Message.ToString() }, JsonRequestBehavior.AllowGet);

                }

                return Json(new { status = "Fail", error = ex.Message.ToString() }, JsonRequestBehavior.AllowGet);
            }
            

        }

        public ActionResult getdata()
        {
            try
            {
                connection();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("showdata", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                string jsondata = JsonConvert.SerializeObject(dt);
                return Json(new { status = "Success", data = jsondata }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = "Fail", data = ex.Message.ToString() });
            }
        }
        public ActionResult deleterecord(int id)
        {
            try
            {
                connection();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("deletedata", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return Json(new { status = "Success" }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { status = "Fail", error = ex.Message.ToString() }, JsonRequestBehavior.AllowGet);
            }
           
        }

        

        public ActionResult getsinglerecord(int ID)
        {
            try
            {
                connection();
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("getsingle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                string jsondata = JsonConvert.SerializeObject(dt);
                return Json(new { status = "Success", data = jsondata }, JsonRequestBehavior.AllowGet);
               
            }
            catch (Exception ex)
            {
                return Json(new { status = "Fail", error = ex.Message.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }




    }
}