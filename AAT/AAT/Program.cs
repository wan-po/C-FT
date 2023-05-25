using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGuid
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            { 
                string guid = Guid.NewGuid().ToString(); //微軟提供的唯一識別亂數
                Console.WriteLine($"{guid},共{guid.Count()}字");
            }
            Console.ReadLine();
        }
    }
}
