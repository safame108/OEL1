using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ClientBased KandN = new ClientBased();
            KandN.AdCharges(90,4);
            ClientBased Samsung = new ClientBased();
            Samsung.AdCharges(50,5);


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
