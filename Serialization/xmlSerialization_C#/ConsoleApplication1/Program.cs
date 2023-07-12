using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication1
{
    //[XMLRoot()] and [XMLElement()] these are the
    //.net attributes and tell the serializer
    //where the various members of this object 
    //will appear in the XML document and what they 
    //will be named. Without these,
    //serialization cannot take place.

    [XmlRoot("MyPerson")]
    public class Person
    {
        private string m_sName;
        private int m_iAge;
        public Person()
        { }
        [XmlElement("Name")]
        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }
        [XmlElement("Age")]
        public int Age
        {
            get { return m_iAge; }
            set { m_iAge = value; }
        }
      
    }

    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer objXmlSer = new XmlSerializer(typeof(Person));
            
            
            Person p1 = new Person();
            
            p1.Name = "Intellect Computers";
            p1.Age = 30;

            StreamWriter sw;
            sw = new StreamWriter(@"E:\abc.xml");
            objXmlSer.Serialize(sw, p1);
            sw.Close();


            Person p2 = new Person();
            StreamReader sr;
            sr = new StreamReader(@"E:\abc.xml");
            XmlSerializer objXmlSer1 = new XmlSerializer(typeof(Person));
            p2 = (Person)objXmlSer1.Deserialize(sr);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Age.ToString());
            Console.ReadKey();



            sr.Close();
        }
    }
}
