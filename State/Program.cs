using State;

Context context = new Context();
ModifiedState modifiedState = new ModifiedState();
modifiedState.DoAction(context);
DeletedState deletedState = new DeletedState();
deletedState.DoAction(context);

Console.WriteLine(context.GetState()?.ToString());