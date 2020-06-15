using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Management_System
{
    public class MainMenuOption
    {
        private SchedulingBasedAdPosting a;
        private ClientCharges b;
        private StatusCheck c;

        public MainMenuOption() {
            a = new SchedulingBasedAdPosting();
            b = new ClientCharges();
            c = new StatusCheck();
        }

        public void ClientChargesAndScheduling() {
            Console.WriteLine(a.SchedulingInfo());
            Console.WriteLine(b.ClientChargesAd() ); 
        }

        public void SC() {
            Console.WriteLine(c.Status()); 
        }
    }
}
