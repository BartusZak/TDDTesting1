using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.CLI
{
    public class Greeter
    {
        public string SayHello(string name)
        {
            return string.Format("Hello, {0}!", name);
            throw new NotImplementedException();
        }
    }
}
