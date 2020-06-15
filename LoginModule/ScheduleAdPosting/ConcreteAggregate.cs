using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAdPosting
{
   public class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public override WebsiteIterator CreateWebsiteIterator()
        {
            return new ConcereteIterator(this);
        }
        public int Count
        {
            get { return _items.Count; }
        }
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }

}

