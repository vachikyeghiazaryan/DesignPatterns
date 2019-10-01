using System.Collections;

namespace IteratorNS.Enumerator
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }

    public class Enumerable : IEnumerable
    {
        private ArrayList arrayList = new ArrayList();

        public object this[int index]
        {
            get { return arrayList[index]; }
            set { arrayList.Insert(index, value); }
        }

        public int Count()
        {
            return arrayList.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }

    public interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    }

    public class Enumerator : IEnumerator
    {
        private readonly Enumerable enumerable;
        private int current = -1;

        public Enumerator(Enumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        public object Current
        {
            get
            {
                return enumerable[current];
            }
        }

        public bool MoveNext()
        {
            if (current < enumerable.Count() - 1)
            {
                ++current;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
