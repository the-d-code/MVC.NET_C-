using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyExample.Service
{
    public class MyService
    {
        public interface IHelloWorlService
        {
            string SayHello();
        }
        public class HelloWorldService : IHelloWorlService
        {
            public string SayHello()
            {
                return "Hello Shubham";
            }
        }
    }
}
