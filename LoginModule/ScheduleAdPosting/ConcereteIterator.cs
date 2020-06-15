using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAdPosting
{
    public class ConcereteIterator : WebsiteIterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcereteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }



        public override object First()
        {
            return _aggregate[0];
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;

        }

    }
}
    
    
    
