using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serializationexm
{
    [Serializable]
    class Customer:ISerializable
    {
        public int CustId, Billno;

        public Customer()
        {
            CustId = 0;
            Billno = 0;
        }
        public Customer(SerializationInfo info,StreamingContext ctxt)
        {
            CustId = (int)info.GetValue("CustomerId", typeof(int));
            Billno = (int)info.GetValue("BillNo",typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CustomerId",CustId);
            info.AddValue("BillNo",Billno);
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Customer cs = new Customer();
            cs.CustId = 101;
            cs.Billno = 1010101;

            Stream stream = File.Open(@"E:\Customer.osl",FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            Console.WriteLine("Writing in Customer File");
            bf.Serialize(stream, cs);
            stream.Close();
            cs = null;


            Console.ReadKey();

        }
    }
}
