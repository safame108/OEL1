using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTApiAdapter
{
   public class Adapter: TargetDeviceInterface
    {
        private RESTAPIAdaptee _adaptee = new RESTAPIAdaptee();

        public override void Request()
        {

            _adaptee.SpecificRequest();
        }
    }
}
