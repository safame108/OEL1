using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTApiAdapter
{
    public class TargetDeviceInterface
    {
        public virtual void Request()
        {
            Console.WriteLine("Calling targetted request");
        }
    }
}
