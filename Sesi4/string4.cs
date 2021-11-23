using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi4
{
    public class string4
    {
        static void Main()
        {
            string stringAwal="C# membuat string mudah.";
            string substr=stringAwal.Substring(5,12);

            System.Console.WriteLine("stringAwal: "+stringAwal);
            System.Console.WriteLine("substring: "+substr);
        }
    }
}