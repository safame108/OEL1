using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAdPosting
{
   public class HeadOfMarkting:Approver
    {
        public override int AdCheck(Advertisement Ad)
        {
            if (Ad.point == 100)
            {
                Console.WriteLine(Ad.point);
                Console.WriteLine("Being Approved..");
            }
            else
            {
                Console.WriteLine("Not approved.");
                return 0;
            }
            return 1;

        }
    }
}
