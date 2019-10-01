namespace AbstractFactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();
        }
    }
}
