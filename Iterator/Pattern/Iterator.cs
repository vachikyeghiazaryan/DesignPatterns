namespace IteratorNS.Pattern
{
    public interface Iterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }
}
