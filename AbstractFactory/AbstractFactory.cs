using AbstractFactoryProject.Bottles;
using AbstractFactoryProject.Covers;
using AbstractFactoryProject.Waters;

namespace AbstractFactoryProject
{
    public abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractCover CreateCover();
    }
}