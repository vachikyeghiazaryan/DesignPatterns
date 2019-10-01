namespace Builder
{
    public class ConcreteBuilder : Builder
    {
        private House _house;

        public ConcreteBuilder()
        {
            this._house = new House();
        }

        public override void BuildBasement()
        {
            this._house.Add(new Basement());
        }

        public override void BuildStorey()
        {
            this._house.Add(new Storey());
        }

        public override void BuildRoof()
        {
            this._house.Add(new Roof());
        }

        public override House GetResult()
        {
            return this._house;
        }
    }
}