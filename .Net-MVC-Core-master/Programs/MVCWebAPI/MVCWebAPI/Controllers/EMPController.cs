using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCWebAPI.Models;

namespace MVCWebAPI.Controllers
{
    public class EMPController : ApiController
    {
        // GET: api/EMP
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public IEnumerable<EmployeeTB> Get()
        {
            return   dc.EmployeeTBs.ToList();
        }

        // GET: api/EMP/5
        public IEnumerable<EmployeeTB> Get(int id)
        {
            return dc.EmployeeTBs.Where(s => s.EmployeeId == id).ToList();
        }

        // POST: api/EMP
        public void Post([FromBody]EmployeeTB emp)
        {
            dc.EmployeeTBs.InsertOnSubmit(emp);
            dc.SubmitChanges();
            
        }

        // PUT: api/EMP/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EMP/5
        public void Delete(int id)
        {
            EmployeeTB data = dc.EmployeeTBs.FirstOrDefault(s => s.EmployeeId == id);
            dc.EmployeeTBs.DeleteOnSubmit(data);
            dc.SubmitChanges();
        }
    }
}
