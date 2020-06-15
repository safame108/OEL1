using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAdPosting
{
    public abstract class Approver
    {
        protected Approver Sucessor;

        public void SetSucessor(Approver name)
        {
            this.Sucessor = name;
        }

        public abstract int AdCheck(Advertisement Ad);

    }
    }
