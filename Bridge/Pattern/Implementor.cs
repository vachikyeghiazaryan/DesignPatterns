namespace Bridge
{
    public abstract class Implementor
    {
        public abstract void OperationImpl();
    }

    public class ConcreteImplementor : Implementor
    {
        public override void OperationImpl()
        {

        }
    }
}