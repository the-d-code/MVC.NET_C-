using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovDec2018
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmpList = new List<Employee>()
            {
                  new Employee() { EmpID = 1, EmpName = "aadghu", Salary = 1000,JoiningDate =new DateTime(2017,1,18),DepName = "Sales"} ,
                  new Employee() { EmpID = 2, EmpName = "snehal", Salary = 2000,JoiningDate =new DateTime(2017,2,18),DepName = "Purchase"} ,
                  new Employee() { EmpID = 3, EmpName = "shuebham", Salary = 3000,JoiningDate =new DateTime(2017,3,18),DepName = "Market"} ,
                  new Employee() { EmpID = 4, EmpName = "vaidehi", Salary = 4000,JoiningDate =new DateTime(2017,4,18),DepName = "Manager"} ,
                  new Employee() { EmpID = 5, EmpName = "karan", Salary = 5000,JoiningDate =new DateTime(2017,5,18),DepName = "Account"} ,
                  new Employee() { EmpID = 6, EmpName = "akshit", Salary = 6000,JoiningDate =new DateTime(2017,6,18),DepName = "Selling"},
                  new Employee() { EmpID = 6, EmpName = "harsh", Salary = 6000,JoiningDate =new DateTime(2017,6,18),DepName = "Selling"},
                  new Employee() { EmpID = 6, EmpName = "divy", Salary = 6000,JoiningDate =new DateTime(2017,6,18),DepName = "Selling"}

            };

            IList<Student> studentList = new List<Student>()
            {
            new Student() { StudentID = 1, StudentName = "John", Age = 13,Year=1 ,State="Rajsthan" ,InstName="abc" } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 ,Year=2 ,State="Rajsthan" ,InstName="abc"} ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 ,Year=3 ,State="Rajsthan" ,InstName="abc"} ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 ,Year=4 ,State="Gujarat" ,InstName="pqr"} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 ,Year=4 ,State="Maharastra" ,InstName="pqr"}
        };

            //var emp = from e in EmpList
            //          group e by e.DepName into egrp
            //          let Max = egrp.Max(s => s.Salary)
            //          select new
            //          {
            //              Deparment = egrp.Key,
            //              Name = egrp.First(v => v.Salary == Max).EmpName,
            //              Sala=egrp.First(v=>v.Salary==Max).Salary
            //          };
           
            //foreach (var e in emp)
            //{
            //    Console.WriteLine(e.Name + " " + e.Sala);
            //}

            //var emps = from e in EmpList
            //          group e by e.DepName into egrp
            //          let Max = egrp.Max(s => s.Salary)
            //          select new
            //          {
            //              Deparment = egrp.Key,
            //              Name = egrp.First(v => v.Salary == Max).EmpName,
            //              Sala = egrp.First(v => v.Salary == Max).Salary
            //          };

            //foreach (var e in emp)
            //{
            //    Console.WriteLine(e.Name + " " + e.Sala);
            //}
            //  Console.ReadLine();

            /*november/december-2018*/
            /*var alldata = from e in EmpList select e;
            foreach(var emp in alldata)
            {
                Console.WriteLine(emp.EmpName);
            }*/

            //var data = from e in EmpList where e.DepName == "Sales" select e;

            /* var data = from e in EmpList where e.DepName == "Manager" select e ;
             var saldata = from sd in data where sd.Salary > 2000 && sd.Salary < 5000 select sd;*/

            // var data = from e in EmpList where e.EmpName.StartsWith("ka") select e;


            /* var data = from e in EmpList where e.JoiningDate.Month == 06 select e ;


             foreach (var emp in data)
             {
                 Console.WriteLine(emp.EmpName);
             }*/

            //int[]  data = { 10, 20, 30, 40, 50, 60, 70 };
            //double sumdata = data.Take(6).Average();
            //Console.WriteLine(sumdata);


            /*November/December-2017*/

            // var data=EmpList.Where(e=>e.DepName=="Sales" || e.DepName=="Manager");
            int today = DateTime.Today.Year;
           // var data = EmpList.Where(e => Convert.ToInt32(e.JoiningDate.Year) - Convert.ToInt32( DateTime.Today.Year));

            //var data = EmpList.Where(e => e.DepName == "Selling" && e.Salary > 3000);

            //var data = EmpList.GroupBy(Emp => Emp.DepName).OrderBy(group => group.Key).Select(group => Tuple.Create(group.Key, group.Count()));
            //var data = EmpList.GroupBy(Emp => Emp.DepName).Select(group => Tuple.Create(group.Key, group.Count()));
            //foreach (var emp in data)
            //{            
            //    if(emp.Item2 > 2)
            //    Console.WriteLine("{0} ", emp.Item1);
            //}


            /*var data = EmpList;
            foreach(var emp in data)
            {
                IEnumerable<char> txt =emp.EmpName;
                foreach(char removechar in "e")
                {
                    var str = from x in txt where x != removechar select x;
                    foreach(char c in str)
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine();
            }*/

            /*var data = EmpList.Where(e => e.Designation == "Manager");
            foreach(var emp in data)
            {
                Console.WriteLine("Name" + emp.EmpName + "DEpartment" + emp.DepName);
            }*/

            /*  March/April-2017 */
            // var data = studentList.Where(s => s.Year == 4 && s.State == "Gujarat");

            /*var data =studentList.GroupBy(s=>s.InstName);
            foreach(var stud in data)
            {
                if(stud.Count()>2)
                {
                    Console.WriteLine(stud.Key);
                }
                Console.WriteLine(stud.Key + stud.Count());
                foreach (var st in stud)
                {
                    Console.WriteLine(st.StudentName);
                }


            }*/
            /*            List<int> salsum = new List<int>();
                        var sum = 0;
                        var data = EmpList.GroupBy(e => e.DepName);
                        foreach(var emp in data)
                        {
                            foreach(var sal in emp)
                            {
                                sum = sum + sal.Salary;
                            }
                            salsum.Add(sum);
                            sum = 0;
                        }
                        foreach(var sal1 in salsum)
                        {
                            Console.WriteLine(sal1);
                        }
                        Console.WriteLine("Max" + salsum.Max());*/


            /* var data = EmpList.Where(e => e.Hobby == "Chess");
             foreach(var emp in data)
             {
                 Console.WriteLine("Name:" + emp.EmpName + "Address" + emp.Address + "Email:" + emp.Email);
             }*/

            /*var data = EmpList.Where(e => e.EmpName.StartsWith("aa") && e.EmpName.Contains("d")&& e.EmpName.Contains("u"));
            foreach (var emp in data)
            {
                Console.WriteLine("Name:" + emp.EmpName +"Salary:"+emp.Salary);
            }*/

            /* MARCH?APRIL-2016*/

            float[] floatdata = { 2.0f, 4.5f, 3.6f, 8.9f, 2.7f, 4.5f, 3.7f, 1.8f, 2.9f, 5.0f, 5.4f };
            //var data = floatdata.Take(8).Average();
            /* var data = floatdata.Average();
             Console.WriteLine("average of 10 no is:" + data);*/

            /*var data = EmpList.Where(e => e.EmpName.Contains("sh"));
            foreach(var emp in data)
            {
                Console.WriteLine("Name:" + emp.EmpName + "Salary:" + emp.Salary);
            }*/

            /*foreach(var emp in EmpList)
            {
                string filename = emp.FileName;
                FileInfo fi = new FileInfo(filename);
                if(fi.Exists)
                {
                    long filesize1 = fi.Length;
                    if(filesize1==1024)
                    {
                        Console.WriteLine(filename);
                    }
                    
                }
                filename = "";
            }*/

            /* foreach (var emp in EmpList)
             {
                 IEnumerable<char> txt = emp.EmpName;
                 foreach (char removechar in "r")
                 {
                     var str = from x in txt where x != removechar select x;
                     foreach (char c in str)
                     {
                         Console.Write(c);
                     }
                 }
                 Console.WriteLine();
             }*/

            /* var data=EmpList.Where(e=>e.DepName=="Sales" || e.DepName=="Purchase" || e.
             DepName=="Selling");
             foreach (var emp in data)
             {
                 Console.WriteLine("Name:" + emp.EmpName + "Salary:" + emp.Salary);
             }*/

            /* vibha-external2015_employee*/
            /*6 no.*/
            /* foreach(var emp in EmpList)
             {
                 var empname = emp.EmpName.Replace("s", string.Empty);
                 Console.WriteLine(empname);
              }*/

            /* MARCH/APRIL-2014*/

            /* var data = EmpList.Where(e => e.EmpName.Contains("a") || e.EmpName.Contains
            ("i"));*/

            /*var avgsal = EmpList.Average(e=>e.Salary);
            var data = EmpList.Where(e1 => e1.Salary > avgsal);
            foreach (var emp in data)
            {
                Console.WriteLine("Name:" + emp.EmpName +" " + "Salary:" + emp.Salary);
            }*/

           // List<int> sal = new List<int>();
            var data = EmpList.GroupBy(e => e.DepName).Select(s=> new { Department=s.Key,avg=s.Average(a=>a.Salary) });
            foreach(var da in data)
            {
                Console.WriteLine("DeptName" + da.Department + "  " + "AvgSalary:" + da.avg);
            }
            //foreach (var emp in data)
            //{
            //    foreach (var empdata in emp)
            //    {
            //        sal.Add(empdata.Salary);
            //    }
            //    var salavg = sal.Average();
            //    Console.WriteLine("DeptName" + emp.Key + "  " + "AvgSalary:" + salavg);
            //    sal.Clear();
            //}

            /* SEPTEMBER/OCTOBER-2014  */
            IList<Product> ProList = new List<Product>()
            {
                new Product() { ProductId = 1, ProductName = "MITV", Price = 13000,Qty=10 ,Category="Electronic" ,Type="television" } ,
                 new Product() { ProductId = 2, ProductName = "SamsungTV", Price = 20000,Qty=17 ,Category="Electronic" ,Type="television" },
                  new Product() { ProductId = 3, ProductName = "IFBMAchine", Price = 24000,Qty=20 ,Category="Electronic-Clean" ,Type="refrigirator" } 
            };


            IList<SalesProduct> SaleList = new List<SalesProduct>()
            {
                new SalesProduct() { SalesProductId=1, ProductId = 1, Price = 13000,Qty=4 ,TotalAmt=69000 } ,
                new SalesProduct() { SalesProductId=2, ProductId = 1, Price = 13000,Qty=2,TotalAmt=26000 } ,
                new SalesProduct() { SalesProductId=3, ProductId = 2, Price = 20000,Qty=3 ,TotalAmt=60000 } ,
                new SalesProduct() { SalesProductId=4, ProductId = 2, Price = 20000,Qty=6 ,TotalAmt=120000 } ,
                new SalesProduct() { SalesProductId=5, ProductId = 2, Price = 20000,Qty=1 ,TotalAmt=20000 } ,
                new SalesProduct() { SalesProductId=6, ProductId = 3, Price = 24000,Qty=2 ,TotalAmt=48000 } ,
                new SalesProduct() { SalesProductId=7, ProductId = 3, Price = 24000,Qty=2 ,TotalAmt=48000 } 

            };
            //var data1 = ProList.Where(p => p.Type == "television").Select(q=> new {Qt=q.});
           
            //var data = ProList.Where(p => p.Category == "Electronic");
            /*var telsum = 0;
            var data = ProList.Where(p => p.Type == "television");
            foreach(var item in data)
            {
                telsum = telsum+item.Qty;
            }
            Console.WriteLine("Qty:" + telsum);*/

            /* var maxprice = ProList.Max(p=>p.Price);
             var data = ProList.Where(p1 => p1.Price == maxprice);
             foreach (var item in data)
             {
                 Console.WriteLine(item.ProductName);
             }*/
            //var proid = 0;
            //var maxsel = SaleList.Max(s => s.TotalAmt);
            //var saldata = SaleList.Where(s1 => s1.TotalAmt == maxsel);
            //foreach(var item in saldata)
            //{
            //    proid = item.ProductId;
            //    var prodata = ProList.Where(p => p.ProductId == proid);
            //    foreach(var data in prodata)
            //    {
            //        Console.WriteLine("PRoductName:" + data.ProductName);
            //    }
            //}




            Console.ReadKey();
        }
    }

    public class Employee
    {

        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string DepName { get; set; }
        public void show()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} ", EmpID, EmpName, Salary, JoiningDate , DepName);
        }
    }

    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public string State { get; set; }
        public string InstName { get; set; }
    }

    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
    }

    public class SalesProduct
    {

        public int SalesProductId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int TotalAmt { get; set; }

    }
}
