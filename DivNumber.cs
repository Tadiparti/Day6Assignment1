using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment1
{
    class DivNumber
    {
        int result;
        DivNumber()
        {
            result = 0;
        }
        public void division(int num1,int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught:{0}", e);
            }
            finally
            {
                Console.WriteLine("Result:{0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNumber d = new DivNumber();
            d.division(58,70);
            Console.ReadKey();
        }
    }
}
