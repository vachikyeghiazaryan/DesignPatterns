using AbstractFactoryProject.Bottles;
using System;

namespace AbstractFactoryProject.Covers
{
    public class CocaColaCover : AbstractCover
    {
        public override void Interact(AbstractBottle bottle)
        {
            Console.WriteLine("Adding cocacola cover to cocacola bottle");
        }
    }
}