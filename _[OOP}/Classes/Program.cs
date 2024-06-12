using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ClassObject;

namespace ClassObject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
        }
    }
}
