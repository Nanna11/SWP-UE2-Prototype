using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordManager sm = SwordManager.GetManager("Swords.txt");
            List<string> swords = sm.SwordList();
            foreach(string s in swords)
            {
                SwordPrototype sword1 = sm[s];
                SwordPrototype sword2 = sm[s];
                if (sword1 == sword2) Console.WriteLine("same sword");
                else Console.WriteLine("only same type of sword");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
