using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Web_Service_MVC.Models;

namespace Web_Service_MVC
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        LinqWithWebServiceDataContext dc = new LinqWithWebServiceDataContext();

        [WebMethod]

        public int Login(string uname ,string pass)
        {
            if(uname!="" && pass!="")
            {
                var q = from x in dc.UserTBs where x.Username.Equals(uname) && x.Password.Equals(pass) select x;
                if(q.Count()>0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
            
        }

        [WebMethod]
        public Object getData()
        {
            var q1 = dc.EmpTBs.ToList();
            return q1.ToList();
        }
        [WebMethod]

        public EmpTB InsertEmployee(EmpTB objemp)
        {
            dc.EmpTBs.InsertOnSubmit(objemp);
            dc.SubmitChanges();

            return objemp;
        }
        public IEnumerable<DeptTB> getDept()
        {
            var q2 = dc.DeptTBs.ToList();
            return q2.ToList();
        }
      

        [WebMethod]

        public EmpTB EditEmployee(int id,EmpTB objemp)
        {
            var q3 = dc.EmpTBs.SingleOrDefault(s => s.Id == id);
            q3.EmpName = objemp.EmpName;
            q3.Salary = objemp.Salary;
            q3.Gender = objemp.Gender;
            q3.DeptId = objemp.DeptId;
            dc.SubmitChanges();
            return q3;

          
           
        }
        [WebMethod]

        public EmpTB FillEmployee(int id)
        {
            var s1 =dc.EmpTBs.SingleOrDefault(s => s.Id == id);
            return s1;
        }
            
        [WebMethod]
        public void DeleteEmployee(int id)
        {
            var delete = dc.EmpTBs.SingleOrDefault(d => d.Id == id);
            dc.EmpTBs.DeleteOnSubmit(delete);
            dc.SubmitChanges();
           
        }
            
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
