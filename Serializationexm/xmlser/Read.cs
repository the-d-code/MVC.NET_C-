using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace xmlser
{
    class Read
    {
        public static void Main(string[] Args)
        {
            Customer cus = new Customer();
            StreamReader rd;
            rd = new StreamReader(@"E:\cust.xml");
            XmlSerializer obj = new XmlSerializer(typeof(Customer));
            cus = (Customer)obj.Deserialize(rd);
            Console.WriteLine(cus.CustId);
            Console.WriteLine(cus.BillNo);

            rd.Close();
            Console.ReadKey();
        }
    }
}
