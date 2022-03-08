using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment1
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                string PersonName = "Siva";
                string PersonPlace = "Kurnool";
                StringBuilder sBuilder = new StringBuilder(PersonName.Length, PersonName.Length);

                sBuilder.Append(PersonName);
                sBuilder.Insert(value: PersonPlace, index: PersonName.Length - 1, count: 1);
            }
            catch(System.OutOfMemoryException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e);
            }
        }
    }
}
