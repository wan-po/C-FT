using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> myDic = new Dictionary<int,string>();
            myDic.Add(0, "Test1");
            myDic.Add(1, "Test2");
            myDic.Add(2, "Test3");
            myDic.Add(3, "Test4");

            Console.WriteLine(myDic[1]);

            int myDicC = myDic.Count;

            for (int i = 0; i < myDicC; i++)
            {
                Console.WriteLine(myDic[i]);
            }
            

            Console.ReadLine();
        }
    }
}
