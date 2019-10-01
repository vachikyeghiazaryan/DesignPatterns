using System.Collections;

namespace IteratorNS.Pattern
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList arrayList = new ArrayList();

        public object this[int index]
        {
            get => arrayList[index];
            set => arrayList.Insert(index, value);
        }

        public int Count()
        {
            return arrayList.Count;
        }

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
