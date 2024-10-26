namespace State
{
    public interface IState
    {
        void DoAction(Context context);
    }

    public class Context
    {
        private IState? _state;

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState? GetState()
        {
            return _state;
        }
    }

    public class ModifiedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State: Modified");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Modified";
        }
    }

    public class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State: Deleted");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Deleted";
        }
    }

    public class AddedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State: Added");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Added";
        }
    }
}
