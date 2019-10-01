namespace Bridge.Example.WithBridge
{
    public abstract class Abstraction
    {
        private readonly Implementor _implementor;

        public Abstraction(Implementor implementor)
        {
            this._implementor = implementor;
        }

        public virtual void Operation()
        {
            this._implementor.OperationImpl();
        }
    }
}