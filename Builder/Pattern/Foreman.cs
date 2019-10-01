namespace Builder
{
    public class Foreman
    {
        private readonly Builder _builder;

        public Foreman(Builder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            this._builder.BuildBasement();
            this._builder.BuildStorey();
            this._builder.BuildRoof();
        }
    }
}