using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PwdGen;

namespace PwdGenDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // uppercase, lowercase, digit, specialSymbols
            PasswordGenerator pg1 = new PasswordGenerator(16, true, true, true, false);
            PasswordGenerator pg2 = new PasswordGenerator();

            Console.WriteLine(pg1.GetPwd());
            Console.WriteLine(pg2.GetPwd(16, true, true, true, true));
        }
    }
}
