using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTest
{
    public class RegexItems
    {
        public string a => "[A-Z]{1}[1-2]{1}[0-9]{8}"; //給Regex用不用加開頭及結尾符號也可以

        public string b => "^[09]{2}[0-9]{8}$";

    }
}
