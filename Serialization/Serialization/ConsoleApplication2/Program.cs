using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication2
{
    [Serializable()]	//Set this attribute to all the classes that you define to be serialized
    public class Employee : ISerializable
    {
        public int EmpId;
        public string EmpName;

        
        public Employee()
        {
            EmpId = 0;
            EmpName = null;
        }

        //Deserialization constructor.
        public Employee(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            EmpId = (int)info.GetValue("EmployeeId", typeof(int));
            EmpName = (String)info.GetValue("EmployeeName", typeof(string));
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("EmployeeId", EmpId);
            info.AddValue("EmployeeName", EmpName);
        }
    }

    //Main class
    public class ObjSerial
    {
        public static void Main(String[] args)
        {
            Employee mp = new Employee();
            mp.EmpId = 101;
            mp.EmpName = "Intellect";

            Stream stream = File.Open(@"E:\EmployeeInfo.osl", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing Employee Information");
            bformatter.Serialize(stream, mp);
            stream.Close();

            mp = null;

            stream = File.Open(@"E:\EmployeeInfo.osl", FileMode.Open);
            bformatter = new BinaryFormatter();

            Console.WriteLine("Reading Employee Information");
            mp = (Employee)bformatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("Employee Id: {0}", mp.EmpId.ToString());
            Console.WriteLine("Employee Name: {0}", mp.EmpName);
            Console.ReadKey();
           
        }
    }
    
}
class abc : ISerializable
{
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        throw new NotImplementedException();
    }
}
