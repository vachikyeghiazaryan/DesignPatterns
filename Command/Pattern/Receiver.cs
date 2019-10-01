using System;

namespace Command.Pattern
{
    public class Receiver
    {
        internal void Action()
        {
            Console.WriteLine("Receiver Action called.");
        }
    }
}