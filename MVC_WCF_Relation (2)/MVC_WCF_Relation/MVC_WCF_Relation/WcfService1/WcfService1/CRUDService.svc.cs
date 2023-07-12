using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Linq;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRUDService" in code, svc and config file together.
    public class CRUDService : ICRUDService
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        

        public string InsertExam(exam ee)
        {
            try
            {
               
                dc.exams.InsertOnSubmit(ee);
                dc.SubmitChanges();
                return "Inserted";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string  UpdateExam(exam ee)
        {
            try
            {
                exam e1 = dc.exams.Single(ee1 => ee1.examid  == ee.examid );
                e1.rno = ee.rno;
                e1.sem = ee.sem;
                e1.examid = ee.examid;
                e1.per = ee.per;
                
                dc.SubmitChanges();
                return "Updated";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public exam  SearchExam(int eid)
        {
            try
            {

                exam e1 = dc.exams.Single(ee1 => ee1.examid == eid);
                return e1;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string DeleteExam(int eid)
        {
            try
            {
            
            exam e1 = dc.exams.Single(ee1 => ee1.examid == eid);
            dc.SubmitChanges();
            return "Delete";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<exam> showallexam()
        {

            try{

                return dc.exams.ToList<exam>();
            }
            catch (Exception e)
            {
                return null ;
            }
        }

        public string InsertStud(stud ss)
        {
            try
            {
                dc.studs.InsertOnSubmit(ss);
                dc.SubmitChanges();
                return "Inserted";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string UpdateStud(stud ss)
        {
            try
            {
                stud s = dc.studs.Single(s1 => s1.rno == ss.rno);
                s.rno = ss.rno;
                s.sname = ss.sname;
                s.course = ss.course;
                dc.SubmitChanges();
                return "Updated";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public stud  SearchStud(int sid)
        {
            try
            {
                stud s = dc.studs.Single(s1 => s1.rno == sid);
                return s;
            }
            catch (Exception e)
            {
                return null; 
            }

        }

        public string  DeleteStud(int sid)
        {
            try
            {
                stud s = dc.studs.Single(s1 => s1.rno == sid);

                dc.studs.DeleteOnSubmit(s);
                dc.SubmitChanges();
                return "Deleted";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<stud>showallstud()
        {
            try
            {
                 

                    /*Load.LoadWith<stud >(d => d.st);
                    foreach (Department dept in context.Departments)
                    {
                        Console.WriteLine(dept.Name);
                        foreach (Employee emp in dept.Employees)
                        {
                            Console.WriteLine("\t" + emp.FirstName + " " + emp.LastName);
                        }
                    }
                }   */
                return dc.studs.ToList();
                //return dc.studs.ToList<stud>();

                
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
