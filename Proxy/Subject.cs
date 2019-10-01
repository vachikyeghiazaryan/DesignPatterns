using System;

namespace Proxy
{
    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Operation!");
        }
    }

    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            _realSubject.Request();
        }
    }
}
