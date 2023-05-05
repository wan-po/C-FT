using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfAndNameOf
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"TypeOf:{typeof(Person)}，NameOf:{nameof(person)}");
            Console.WriteLine($"TypeOf:{typeof(string)}");
            //Typeof會將namespace也印出，nameof就是單純的名字而已
            Console.ReadLine();
        }
    }
}
