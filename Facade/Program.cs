﻿namespace FacadeNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodAB();
            facade.MethodCD();
        }
    }
}
