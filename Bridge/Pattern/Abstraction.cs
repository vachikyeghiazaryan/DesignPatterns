namespace Bridge
{
    public class Abstraction
    {
        private Implementor _implementor;

        public Abstraction(Implementor implementor)
        {
            this._implementor = implementor;
        }
        public virtual void Operation()
        {
            this._implementor.OperationImpl();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor)
            : base(implementor)
        { }

        public override void Operation()
        {
            //

            base.Operation();

            //
        }
    }
}