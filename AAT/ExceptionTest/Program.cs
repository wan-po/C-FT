using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2 };
            GetValueFromArray(a, 5);
            Console.ReadLine();
           
        }
        static int GetValueFromArray(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException e)
            {
               
                throw new ArgumentOutOfRangeException(
                    "Parameter index is out of range.", e);
            }
        }
    }
}
