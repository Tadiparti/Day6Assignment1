using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment1
{
    class NullRef
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            catch(NullReferenceException err)
            {
                Console.WriteLine("Please check the string str.");
                Console.WriteLine(err.ToString());
            }
            Console.WriteLine("Continuing with other statments..");
        }
    }
}
