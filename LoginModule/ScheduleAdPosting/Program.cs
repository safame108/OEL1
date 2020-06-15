using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAdPosting
{
    class Program
    {
        static void Main(string[] args)
        {
            int approved;
            Approver SM = new SeniorManage();
            Approver M = new Managr();
            Approver HOM = new HeadOfMarkting();

            M.SetSucessor(SM);
            SM.SetSucessor(HOM);

            Advertisement AD1 = new Advertisement(50, "K&Ns");
           approved= SM.AdCheck(AD1);
            Console.WriteLine();  

            ConcreteAggregate a = new ConcreteAggregate();

            if (approved ==1)
            {
                a[0] = AD1.name;
            }
      
            WebsiteIterator i = a.CreateWebsiteIterator();

            Console.WriteLine("Iterating over ADS collection:");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }

    }
}
