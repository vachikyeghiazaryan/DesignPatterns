namespace IteratorNS.Pattern
{
    public interface Aggregate
    {
        Iterator CreateIterator();
        int Count();
        object this[int index] { get; set; }
    }
}
