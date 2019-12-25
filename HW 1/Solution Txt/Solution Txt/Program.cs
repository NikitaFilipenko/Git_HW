using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_Txt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
        static string GetLastHalf(string text)
        {
            text = text.Replace(" ", String.Empty);
            string c = text.Substring(text.Length / 2);
            return c;
        }

    }

}
    
