using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullname = "Jin Xian";
            String phonenum = "123-456-7890";

            /*
            fullname = fullname.ToUpper();
            fullname = fullname.ToLower();
            Console.WriteLine(fullname);
            */

            //Console.WriteLine(phonenum.Replace("-", ""));

            //String username = fullname.Insert(0, "Mr. ");
            //Console.WriteLine(username);

            //Console.WriteLine(fullname.Length);

            String firstname = fullname.Substring(0, 3);
            Console.WriteLine(firstname);

            String lastname = fullname.Substring(4);
            Console.WriteLine(lastname);

            Console.ReadKey();
        }
    }
}
