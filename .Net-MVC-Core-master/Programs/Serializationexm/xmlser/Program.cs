using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;


namespace xmlser
{
    [XmlRoot("MyCust")]
    public class Customer
    {
        private int cid,bno;

        public Customer()
        {

        }
        [XmlElement("CustomerId")]
        public int CustId
        {
            get { return cid; }
            set { cid = value; }
        }
        [XmlElement("BillNo")]
        public int BillNo
        {
            get { return bno; }
            set { bno = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer objXmlSer = new XmlSerializer(typeof(Customer));
            Customer c1 = new Customer();
            c1.CustId = 10;
            c1.BillNo = 111;
            StreamWriter sw;
            sw = new StreamWriter(@"E:\Cust.xml");
            objXmlSer.Serialize(sw,c1);
            sw.Close();

        }
    }
}
