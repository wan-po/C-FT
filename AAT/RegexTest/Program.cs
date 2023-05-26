using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Info> myInfo = new List<Info>() {
                new Info(){ 
                    IDCard = "Ab23456789",
                    PhoneNumber = 0921442001
                },
                new Info(){
                    IDCard = "A212345678",
                    PhoneNumber = 991234567
                }
            };
            
            RegexItems myRegex = new RegexItems();
            Console.WriteLine(myRegex.a);

            var z = myInfo.Single(x => Regex.IsMatch(x.IDCard,myRegex.a));
            Console.WriteLine(z.IDCard);
            
            Console.ReadLine();
        }
    }
}
