using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    class Program
    {
        static void Main(string[] args)
        {
            StaffLoginId sl = new StaffLoginId();
            sl.Username = "sana";
            Staff s = new Staff();
            s.Name = "sana";

            StaffAction sa = StaffAction.Logged(sl);
            Console.WriteLine(sa.getUsername());
            Console.ReadLine();
         

        }
    }
}
