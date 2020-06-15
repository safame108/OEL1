using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    public class StaffAction
    {
        private static StaffAction _obj;
        public static Staff s;

        private StaffAction(StaffLoginId staff) {
            s = new Staff();
            s.Name = staff.Username;

        }
    
        static public StaffAction Logged(StaffLoginId sta)
        {

            if (_obj == null)
            {
                _obj = new StaffAction(sta);
            }

            return _obj;
        }

        public string getUsername() {
            return s.Name ;
        }

    }
}
