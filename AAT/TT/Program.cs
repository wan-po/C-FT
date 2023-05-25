using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2023, 04, 1, 0, 0, 0);

            Console.WriteLine(dateTime.Date);
            Console.ReadLine();
        }
    }
}
