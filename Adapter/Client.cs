namespace Adapter
{
    public class Client
    {
        public void Run()
        {
            Adapter adapter1 = new ConcreteAdapter1();
            adapter1.Operation();

            // adapts specific adapter interface to adapter interface
            Adapter adapter2 = new ConcreteAdapter2();
            adapter2.Operation();
        }
    }
}