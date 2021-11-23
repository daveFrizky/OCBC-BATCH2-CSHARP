using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi4
{
    public class string1
    {
        static void Main()
        {
            char[] charray={'1',' ','s','t','r','i','n','g','.'};
            string str1=new string(charray);
            string str2="String lain.";

            System.Console.WriteLine(str1);
            System.Console.WriteLine(str2);
        }
    }
}