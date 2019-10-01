namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("root");
            Component child1 = new Composite("child 1");
            Component child2 = new Composite("child 2");
            Component child3 = new Composite("child 3");
            Component child4 = new Leaf("child 4");

            Component child1_1 = new Composite("child 1 1");
            Component child1_2 = new Leaf("child 1 2");


            root.Add(child1);
            root.Add(child2);
            root.Add(child3);
            root.Add(child4);

            child1.Add(child1_1);
            child1.Add(child1_2);

            root.Operation();
        }
    }
}
