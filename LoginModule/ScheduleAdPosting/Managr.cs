using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAdPosting
{
   public class Managr:Approver
    {
        public override int AdCheck(Advertisement Ad)
        {
            if (Ad.point == 0)
            {
                Console.WriteLine(Ad.point);
                Console.WriteLine("Being Approved..");
            }
            else if (Sucessor != null)
            {
                Sucessor.AdCheck(Ad);
            }
            return 1;

        }

    }
}
