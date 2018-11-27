using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int den = 0;
            int result = 0;
            try
            {
                result = 7 / den;
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Div0error");
            }
            catch ( Exception e)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
    }
}
