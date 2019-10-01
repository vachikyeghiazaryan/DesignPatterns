using AbstractFactoryProject.Bottles;
using AbstractFactoryProject.Covers;
using AbstractFactoryProject.Waters;

namespace AbstractFactoryProject
{
    public class Client
    {
        private readonly AbstractFactory _abstractFactory;
        private AbstractWater _water;
        private AbstractBottle _bottle;
        private AbstractCover _cover;

        public Client(AbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
            this._water = _abstractFactory.CreateWater();
            this._bottle = _abstractFactory.CreateBottle();
            this._cover = _abstractFactory.CreateCover();
        }

        public void Run()
        {
            _bottle.Interact(_water);
            _cover.Interact(_bottle);
        }

    }
}