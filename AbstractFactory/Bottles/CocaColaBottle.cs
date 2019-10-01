using AbstractFactoryProject.Waters;
using System;

namespace AbstractFactoryProject.Bottles
{
    public class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine("filling cocacola water into cocacola bottle");
        }
    }
}