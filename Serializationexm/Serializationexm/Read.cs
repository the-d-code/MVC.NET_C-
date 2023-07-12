using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;                    

namespace Serializationexm
{
    class Read
    { 
   
        public static void Main(string[]args)
        {
            Customer cus = new Customer();
            Stream stream = File.Open(@"E:\Customer.osl",FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Console.WriteLine("Reading from file");
            cus = (Customer)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine("Customer Id-{0}",cus.CustId.ToString());
            Console.WriteLine("Bill No-{0}", cus.Billno.ToString());
            Console.ReadKey();
        }
    }
   
}
