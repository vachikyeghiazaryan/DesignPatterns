namespace Adapter
{
    public class ConcreteAdapter2 : Adapter
    {
        private Adaptee _adaptee = new Adaptee();
        public override void Operation()
        {
            this._adaptee.SpecificOperation();
        }
    }
}