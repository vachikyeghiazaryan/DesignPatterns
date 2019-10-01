namespace Singleton
{
    public class Singleton
    {
        private static Singleton InstanceObj;

        public static Singleton Instance
        {
            get
            {
                if (InstanceObj == null)
                {
                    InstanceObj = new Singleton();
                }

                return InstanceObj;
            }
        }
    }
}