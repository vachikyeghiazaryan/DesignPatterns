namespace IteratorNS.Pattern
{
    public class ConcreteIterator : Iterator
    {
        private readonly Aggregate aggregate;
        private int current = 0;

        public ConcreteIterator(Aggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public object First()
        {
            return aggregate[0];
        }

        public object Next()
        {
            if (current++ < aggregate.Count() - 1)
            {
                return aggregate[current];
            }

            return null;
        }

        public bool IsDone()
        {
            if (current < aggregate.Count())
            {
                return false;
            }

            current = 1;

            return true;
        }

        public object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
