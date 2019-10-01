namespace State.Pattern
{
    public class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }

    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB: State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
