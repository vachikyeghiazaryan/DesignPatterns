using AbstractFactoryProject.Bottles;
using AbstractFactoryProject.Covers;
using AbstractFactoryProject.Waters;

namespace AbstractFactoryProject
{
    public class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}