using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenuOption mm = new MainMenuOption();
            mm.ClientChargesAndScheduling();
            mm.SC();
            Console.ReadLine();
            
        }
    }
}
